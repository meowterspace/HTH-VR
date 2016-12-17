import requests
import random

from flask import Flask
app = Flask(__name__)

SONGS = [
    "0bYg9bo50gSsH3LtXe2SQn", # All I want for Christmas is you
    "01h424WG38dgY34vkI3Yd0", # White Christmas         
    "3QiAAp20rPC3dcAtKtMaqQ", # Blue Christmas
    "6tjituizSxwSmBB5vtgHZE", # Holly Jolly Christmas 
    "0QPYn15U8IQHKcH2LDfrek", # Last Christmas
    "7inXu0Eaeg02VsM8kHNvzM", # Let it Snow 
    "2IuUMx3uxxJAHcH41aYtn0", # Winter Wonderland
    "0lLdorYw7lVrJydTINhWdI", # It's beginning to look a lot like Christmas
    "1DnSNqCQM3LUxqFuXt184Q", # Have yourself a merry little Christmas
    "5hslUAKq9I9CG2bAulFkHN"  # It's the most wonderful time of the year
]
NUM_SONGS = 4

# For each song in the songs list, grab the info and stuff.
SONGS_DATA = []
TRACK_URLS = []

for song in SONGS:
    data = requests.get("https://api.spotify.com/v1/tracks/%s" % song).json()
    SONGS_DATA.append(data)
    TRACK_URLS.append(data["preview_url"])
    # Get all the titles and put them into TITLES
    # For each title, grab the lyrics from the Genius API
    # Do some analysis and shit on the lyrics (yay... NLP - I guess Tom will do this later on)


@app.route('/getsongs')
def get_songs():
    songs_to_play = []
    while not (len(songs_to_play) == NUM_SONGS):
        choice = random.choice(SONGS)
        if choice not in songs_to_play:
            songs_to_play.append(choice)
    
    for song in songs_to_play:
        pass
            
  
