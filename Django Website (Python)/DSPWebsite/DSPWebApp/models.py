from django.db import models

# Create your models here.
#============================================DEBUG============================================
#Manual additions to the database for Debugging -> In python shell (Command: python manage.py shell) 
#1. from DSPWebApp.models import ScoreDataPuzzleOne
#2. scoreData = ScoreDataPuzzleOne(userName="TEST",score="1000",dateAdded="2001-08-25")
#3. scoreData.save()
#4. ScoreDataPuzzleOne(userName="TEST2",score="500",dateAdded="2001-08-25").save() Do both add and save at the same time
#5. ScoreDataPuzzleOne.objects.all() #shows QuerySet (Print all in database entries)
#6. ScoreDataPuzzleOne.objects.get(id=1) # increment numerical value for each item in database (Code for viewing individual database entry)
#7. ScoreDataPuzzleOne.objects.get(id=1).delete() #Deletes a given record in the ScoreDataPuzzleOne table
#8. python manage.py flush #Clears database completely (Reset)
#=============================================================================================

#Class: Database model ScoreDataPuzzleOne lays out user name, score for puzzle one, and time submitted
class ScoreDataPuzzleOne(models.Model):
    userName = models.CharField(max_length=200)
    score = models.CharField(max_length=200)
    
    #Allows content to be printed out when database debugging
    def __str__(self):
        return "User's Name: " + self.userName + " score: " + self.score