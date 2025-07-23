from fastapi import APIRouter
from urllib.parse import urlparse
from PageDate import PageDate

router = APIRouter()

@router.post("/scrape/class")
def scrape(pageDate: PageDate):
    return True