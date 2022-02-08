from unicodedata import name
from xml.etree.ElementInclude import include
from django.urls import URLPattern, path

from . import views
from .views import RestApi
urlpatterns = [
    path('', views.index, name='home'),
    path('eightQueensLeader/', views.eightQueensLeader, name='eightQueensLeader'),
    path('2048Leader/', views.eightQueensLeader, name='2048Leader'),
    path('aboutPage/', views.aboutPage, name='aboutPage'),
    path('restpost/', RestApi.as_view()),
]
