import socket
import uvicorn
from fastapi import FastAPI
import Server
from Server import app 
from Server import port
import webbrowser

def find_free_port():
    """OSから使用可能な空いているポートを取得する"""
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.bind(("", 0))  # OSにポートを選ばせる
        return s.getsockname()[1] # 使用されたポート番号を返す
    
if __name__ == "__main__":
    Server.port = find_free_port()    
    webbrowser.open(f'http://localhost:{Server.port}/')
    
    uvicorn.run(app, host="localhost", port=Server.port,  log_config=None)
