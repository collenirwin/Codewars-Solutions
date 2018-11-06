int startsWith(const char *string, const char *prefix) {
  int slen = strlen(string);
  int plen = strlen(prefix);

	if (slen < plen) {
    return 0;
  }
  
  for (int x = 0; x < plen; x++) {
    if (string[x] != prefix[x]) {
      return 0;
    }
  }
  
  return 1;
}