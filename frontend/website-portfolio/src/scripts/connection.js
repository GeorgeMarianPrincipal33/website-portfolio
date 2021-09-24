import {BACKEND} from './variables'

var axios = require("axios");

export async function getCVs() {
    const url = BACKEND + "CV/GetCVs";
  
    return axios.get(url);
}

export async function login(username, password){
    const url = BACKEND + `User/LoginFunction?userName=${username}&password=${password}`;
    console.log('connection, ', url)
  
    // return axios.get(url);
}