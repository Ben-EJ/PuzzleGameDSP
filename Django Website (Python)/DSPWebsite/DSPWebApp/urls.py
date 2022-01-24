from unicodedata import name
from xml.etree.ElementInclude import include
from django.urls import URLPattern, path

from . import views
from .views import RestApi
urlpatterns = [
    path('', views.helloWorld),
    path('RestApi/', RestApi.as_view()),
]