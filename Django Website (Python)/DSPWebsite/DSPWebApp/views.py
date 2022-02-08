from http.client import HTTPResponse
import imp
from django.shortcuts import render
from django.http import HttpResponse
from .models import ScoreData2048, ScoreDataPuzzleOne #imports database model
# Create your views here.
# A view function takes a HTTP request and returns a response (Request Handler)

#86.134.228.24:8765
from django.views import View
from django.http import JsonResponse
import json
from django.utils.decorators import method_decorator
from django.views.decorators.csrf import csrf_exempt

"""
For tesing POST request in console:
curl --header "Content-Type: application/json" \ --request POST \ --data '{\"userName\":\"RESTAPITEST\", \"score\":\"5000\"}' \ -url "http://127.0.0.1:8000/index/RestApi/"
"""
#Rest API class
@method_decorator(csrf_exempt, name='dispatch')
class RestApi(View):
    #Handles post requests
    def post(self, request):
        jsonData = json.loads(request.body.decode("utf-8"))
        userNameFromJson = jsonData.get('userName')
        scoreFromJson = jsonData.get('score')
        ScoreDataPuzzleOne(userName=userNameFromJson,score=scoreFromJson).save()
        return JsonResponse(jsonData, status=201)


def index(request):
    return render(request, 'index.html')

def aboutPage(request):    
    return render(request, 'about.html')

def eightQueensLeader(request):    
    all_records = ScoreDataPuzzleOne.objects.all()#gets database table (Database query)
    return render(request, 'eightqueensleader.html', {'all_records' : all_records})

def eightQueensLeader(request):    
    all_records = ScoreData2048.objects.all()#gets database table (Database query)
    return render(request, '2048Leader.html', {'all_records' : all_records})