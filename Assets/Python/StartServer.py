import socket
import uvicorn
from fastapi import FastAPI
from Server import app 

def find_free_port():
    """OSから使用可能な空いているポートを取得する"""
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.bind(("", 0))  # OSにポートを選ばせる
        return s.getsockname()[1]  # 使用されたポート番号を返す
    
if __name__ == "__main__":
    port = find_free_port()
    uvicorn.run(app, host="localhost", port=port,  log_config=None)
