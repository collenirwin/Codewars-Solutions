function solve(st, a, b) {
  return st.substring(0, a) +
    st.substring(a, b + 1).split("").reverse().join("") +
    st.substring(b + 1);
}