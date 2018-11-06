std::string itinerary(std::vector<Route> travel)
{
  std::string route = travel.at(0).in + "-" + travel.at(0).out;
  
  for (int x = 1; x < travel.size(); x++)
  {
    if (travel.at(x - 1).out != travel.at(x).in)
    {
      route += "-" + travel.at(x).in + "-" + travel.at(x).out;
    }
    else
    {
      route += "-" + travel.at(x).out;
    }
  }
  
  return route;
}