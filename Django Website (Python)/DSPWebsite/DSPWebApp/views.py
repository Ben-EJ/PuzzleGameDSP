from http.client import HTTPResponse
import imp
from django.shortcuts import render
from django.http import HttpResponse
from .models import ScoreDataPuzzleOne #imports database model
# Create your views here.
# A view function takes a HTTP request and returns a response (Request Handler)


from django.views import View
from django.http import JsonResponse
import json
from django.utils.decorators import method_decorator
from django.views.decorators.csrf import csrf_exempt

"""
For tesing POST request in console:
curl --header "Content-Type: application/json" 
  --request POST 
  -d '{"userName":"xyz","score":"5000","dateAdded":"2001-08-25"}' 
  http://127.0.0.1:8000/index/RestApi/
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


def helloWorld(request):
    all_records = ScoreDataPuzzleOne.objects.all()#gets database table (Database query)
    
    return render(request, 'home.html', {'all_records' : all_records})