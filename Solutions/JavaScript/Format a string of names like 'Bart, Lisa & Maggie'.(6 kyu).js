function list(names) {
  const n = names.map(x => x.name);
  return n && n.length > 1
    ? n.slice(0, -1).join(", ") + " & " + n[n.length - 1]
    : n.length === 1
      ? n[0]
      : "";
}