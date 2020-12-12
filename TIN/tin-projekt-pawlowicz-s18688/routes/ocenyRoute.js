const express = require('express');
const router = express.Router();
const ocenyControler = require('../controllers/ocenyController');
router.get('/', ocenyControler.showOcenyList);
router.get('/add', ocenyControler.showAddOcenaForm);
router.get('/edit/:ocenaId', ocenyControler.showEditOcenaForm);
router.get('/details/:ocenaId', ocenyControler.showOcenaDetails);
router.post('/add', ocenyControler.addOcena);
router.post('/edit', ocenyControler.updateOcena);
router.get('/delete/:ocenaId', ocenyControler.deleteOcena);
module.exports = router;