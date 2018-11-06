import java.net.URL;
import java.util.HashMap;

public class UrlMap {
  HashMap<String, Long> urls = new HashMap<String, Long>();

  public void setTimestamp(URL url, long timestamp) {
    urls.put(url.toString(), timestamp);
  }

  public long getTimestamp(URL url) {
    Long timestamp = urls.get(url.toString());
    return timestamp != null ? timestamp : -1;
  }
}