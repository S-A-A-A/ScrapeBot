from fastapi import FastAPI
from routers import Item

app = FastAPI()
port = None

# ルータをアプリに追加
app.include_router(Item.router)

@app.get("/port")
def GetPort():
    return port