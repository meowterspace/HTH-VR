import requests
import random
import base64

from flask import Flask
app = Flask(__name__)

SPOTIFY_AUTH_KEY = "BQAS9tTsjOivKOy2xxccKR2pR_iW5yAUmBSk7ODtmKn9IGyn-1mCzRY36awT0AygZ9Pu8sA9Dr7HA-YxvhNPxhvMjtRCchtwV6ZnTjzL2VRBlvfLx8qA7iIBQwwBTysI1cC7HBaJ6x_ecw" 
GENIUS_AUTH_KEY = "_cBOSOI5HOcIW2ZYSw8q--24zq1Pv2b5a9X6HSmAI8Pr8CCuAV3GbV6Tw7Y-pGJO" 

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
TRACKS = []
TITLES = [] 
LYRICS = [] 
ANALYSES = [] 

for song in SONGS:
    data = requests.get("https://api.spotify.com/v1/tracks/%s" % song).json()
    SONGS_DATA.append(data)
    TRACK_URLS.append(data["preview_url"])
    # Get all of the MP3(A?) files from the urls and shiz
    mp3a_data = base64.b64encode(requests.get(data["preview_url"]).content)
    TRACKS.append(mp3a_data)
    # TODO: Probably change the format to WAV because WAV is nice ~Tom
    # Get all the titles and put them into TITLES
    TITLES.append(data["name"])
    # For each title, grab the lyrics from the Genius API and put them into LYRICS
    # LYRICS.append(requests.get("http://api.genius.com/search?q=%s"%data["name"], headers={"Authorization": "Bearer %s"%GENIUS_AUTH_KEY}).text) 
    # Do some analysis and shit on the lyrics (yay... NLP - I guess Tom will do this later on)
    # analysis = requests.get("https://api.spotify.com/v1/audio-analysis/%s"%song, headers={"Authorization": "Bearer %s"%SPOTIFY_AUTH_KEY}).text
    # ANALYSES.append(analysis)

@app.route('/getsongs')
def get_songs():
    json_data = []
    songs_to_play = []
    indexes = []
    while not (len(songs_to_play) == NUM_SONGS):
        choice = random.choice(SONGS)
        if choice not in songs_to_play:
            songs_to_play.append(choice)
            indexes.append(SONGS.index(choice))
    for i in range(NUM_SONGS):
        song_data = {
            'id': songs_to_play[i],
            'title': TITLES[i],
            'mp3a': TRACKS[i] #,
            #'analysis': ANALYSES[i]
        }
        json_data.append(song_data)
    with open("test.json", "w") as f:
        f.write(str(json_data))
    return str(json_data)
 
@app.route('/gettitles') 
def get_titles():
    return str(TITLES)
