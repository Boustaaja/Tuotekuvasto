# Tuotekuvasto
Luodaan uusi Core Web Application (model-view-controller), tutkitaan sen sisältöä ja eritellään keskeiset osat

MVC = model, view ja controller, jakaa sovelluksen kolmeen eri osaan.
Nämä osat työskentelevät yhdessä datan, käyttöliittymän ja vuorovaikutusten hallitsemiseksi.

# Model: 
- Vastaa sovelluksen datasta ja liiketoimintalogiikasta.
- Pitää sisällään sovelluksen käyttämät tiedot ja tietomallit sekä tiedon käsittelyä koskevan logiikan.
- Datan hakeminen ja tallentaminen tietokannasta
- Datan muokkaaminen ja esim. validointi
- Sovelluslogiikan toteutus, laskenta, ehdot

# View:
- Vastaa käyttöliittymästä
- Käyttäjä näkee ja syöttää dataa
- Esittää käyttäjälle Controllerilta saadun datan
- Tarjoaa käyttäjälle käyttöliittymän vuorovaikutukseen sovelluksen kanssa
- Tyypillisesti Razor-näkymä(.cshtml)
- Ei sisällä sovelluslogiikkaa
- Tehtävä on datan näyttäminen ja käyttäjän syötteiden vastaanottaminen

# Controller: 
- Kuvaa tuotteen tietoja 
- Toimii välittäjänä View:n ja Modelin välillä.
- Käsittelee käyttäjän tekemät pyynnöt
- Kutsuu oikeaa Model-luokkaa datan käsittelyä varten
- Palauttaa datan Viewlle
- Vastuulla sovelluksen logiikan hallinta(URL-reititys, datan yhdistäminen oikeaan näkymään)

# ProductController.cs
- Controller
- Saa HTTP-pyynnöt, käsittelee Modelin datan ja lähettää sen View:lle

# products.json
- Model
- Sisältää datan jota Model käsittelee
  
# Product.cshtml.
- View
- Näyttää käyttäjälle ProductController-luokan käsittelemän datan

