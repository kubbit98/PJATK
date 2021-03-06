package zad1;

import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.util.function.Function;

public class InputConverter<T>{
	List<String> list;
	public InputConverter(String address){
		try{
			BufferedReader br=new BufferedReader(new FileReader(new File(address)));
			list=new ArrayList<>();
			String line;
			while((line=br.readLine())!=null){
				list.add(line);
			}
		}catch(IOException e){
			e.printStackTrace();
		}
	}
	public InputConverter(List<String> list){
		this.list=list;
	}

	public <T> T convertBy(Function... func){
		List<T> l=new ArrayList<>();
		l.add(((T)func[0].apply(this.list)));
		for(int i=1;i<func.length;i++){
			l.add(((T)func[i].apply(l.get(i-1))));
		}
		return l.get(l.size()-1);
	}
}
