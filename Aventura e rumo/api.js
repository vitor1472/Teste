import axios from 'axios';

const api = axios.create({
    baseURL: "https://localhost:7293/"  // Use "http" ao invés de "https" se o servidor não estiver configurado para SSL
  });
  

export default api;

