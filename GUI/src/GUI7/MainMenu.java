package GUI7;

import java.awt.*;
import java.io.IOException;
import java.util.Scanner;

class MainMenu {
    static void readFile(){
        try {
            FileOperations.readBin(Main.file, Main.figures);
        } catch (IOException e) {
            System.err.println("Nie znaleziono pliku do odczytu");
        }
    }
    static void writeFile(){
        try {
            FileOperations.writeAllBin(Main.file,Main.figures);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    private static void generateFrame(){
        if(Main.frame==null){
            EventQueue.invokeLater(() -> Main.frame=new MyFrame(Main.model));
        }
        while(Main.frame==null){
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
    static void graphicalMode(){
        EventQueue.invokeLater(() -> Main.frame=new MyFrame(Main.model));
    }
    static void standardMode(){
        generateFrame();
        Thread th = new Thread(() -> {
            while(!Main.endOfProgram){
                Figures tmp=Figures.generateFigure();
                Main.figures.add(tmp);
                Main.frame.drawPanel.drawFigure(tmp);
                try {
                    FileOperations.writeOneObjectBin(Main.file, tmp);
                    Thread.sleep(Main.time);
                }catch (InterruptedException e) {
                    e.printStackTrace();
                }catch (IOException e) {
                    System.err.println("Błąd zapisu do pliku");
                }
                if(Main.maxNumberOfFigures!=0 && Main.figures.size()>Main.maxNumberOfFigures){
                    System.out.println("Osiągnięto limit figur");
                    Main.endOfProgram=true;
                }
            }
        });
        th.start();
    }
    static void standardModeWithoudWrite(){
        generateFrame();
        Thread th = new Thread(() -> {
            while(!Main.endOfProgram){
                Figures tmp=Figures.generateFigure();
                Main.figures.add(tmp);
                Main.frame.drawPanel.drawFigure(tmp);
                try {
                    Thread.sleep(Main.time);
                }catch (InterruptedException e) {
                    e.printStackTrace();
                }
                if(Main.maxNumberOfFigures!=0 && Main.figures.size()>Main.maxNumberOfFigures){
                    System.out.println("Osiągnięto limit figur");
                    Main.endOfProgram=true;
                }
            }
        });
        th.start();
    }

    static void consoleMode(){
        System.out.println(
                "Jaką akcje chcesz wykonać?\n" +
                        "1: Uruchom program\n" +
                        "2: Uruchom program bez wczytania figur z pliku\n" +
                        "3: Wygeneruj nowe kształty i wyświetl\n" +
                        "4: Wygeneruj nowe kształty, wyświetl i zapisz do pliku\n" +
                        "5: Wczytaj kształty z pliku i wyświetl\n" +
                        "6: Wyczyść plik z danych\n" +
                        "0: Przerwij program\n"
        );

        int userChoice=new Scanner(System.in).nextInt();
        switch (userChoice){
            case 1:
                readFile();
                standardMode();
                break;
            case 2:
                standardMode();
                break;
            case 3:
                System.out.println("Ile kształtów chcesz wygenerować?");
                Figures.generateFigures(new Scanner(System.in).nextInt());
                generateFrame();
                Main.frame.drawPanel.repaint();
                break;
            case 4:
                System.out.println("Ile kształtów chcesz wygenerować?");
                Figures.generateFigures(new Scanner(System.in).nextInt());
                generateFrame();
                Main.frame.drawPanel.repaint();
                writeFile();
                break;
            case 5:
                readFile();
                generateFrame();
                break;
            case 6:
                FileOperations.clearFile(Main.file);
                break;
            default:
                System.out.println("Zły wybór");
            case 0:
                System.out.println("Wyłączanie");
                break;
        }
    }
}
