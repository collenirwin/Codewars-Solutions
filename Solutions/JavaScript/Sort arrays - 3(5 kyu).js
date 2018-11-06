sortme = function(courses) {
  const setup = (course) => {
    course = course.split("-");
    return course[1] + course[0]
  };
  
  return courses.sort((x, y) => setup(x) > setup(y));
};