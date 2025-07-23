from pydantic import BaseModel
from urllib.parse import urlparse

class PageDate(BaseModel):
    url: str = None
    name: str = None
    id: str = None
    