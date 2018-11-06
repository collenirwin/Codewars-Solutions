function stripUrlParams(url, paramsToStrip) {
  const qMarkIndex = url.indexOf("?");
  
  if (qMarkIndex === -1) {
    return url;
  }
  
  const params = url.slice(qMarkIndex + 1).split("&");
  
  url = url.substring(0, qMarkIndex + 1);
  
  const usedParams = paramsToStrip || [];
  const finalParams = [];
  
  for (let param of params) {
    const paramName = param.substring(0, param.indexOf("="))
    
    if (usedParams.indexOf(paramName) === -1) {
      usedParams.push(paramName);
      finalParams.push(param);
    }
  }
  
  return url + finalParams.join("&");
}