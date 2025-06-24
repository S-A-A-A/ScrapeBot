import socket
import uvicorn
from fastapi import FastAPI

# FastAPIアプリケーションを作成
app = FastAPI()

@app.get("/")
def read_root():
    return {"message": "Hello, FastAPI!"}

def find_free_port():
    """OSから使用可能な空いているポートを取得する"""
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.bind(("", 0))  # OSにポートを選ばせる
        return s.getsockname()[1]  # 使用されたポート番号を返す
    
if __name__ == "__main__":
    port = find_free_port()
    print(f"Starting server on http://localhost:{port}")
    uvicorn.run(app, host="localhost", port=port)
