from fastapi import FastAPI
from routers import Item

app = FastAPI()

# ルータをアプリに追加
app.include_router(Item.router)