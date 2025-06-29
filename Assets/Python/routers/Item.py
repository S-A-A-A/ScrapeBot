from fastapi import APIRouter

router = APIRouter()

@router.get("/items")
def get_items():
    return [{"item": "Pen"}, {"item": "Notebook"}]
