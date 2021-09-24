import {BACKEND_URL} from './variables'

var axios = require("axios");

export async function getCVs() {
    const url = BACKEND_URL + "CV/GetCVs";
  
    return axios.get(url);
}

export async function login(username, password){
    const url = BACKEND_URL + `/Users/LoginFunction?userName=${username}&password=${password}`;
    
    return axios.get(url);
}