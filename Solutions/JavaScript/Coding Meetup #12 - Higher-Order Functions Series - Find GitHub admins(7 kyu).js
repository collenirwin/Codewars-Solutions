function findAdmin(list, lang) {
  return list.filter(x => x.language === lang && x.githubAdmin === "yes");
}