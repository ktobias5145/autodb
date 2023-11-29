const serverURL = "http://localhost:5219/api/";
//const serverURL = "/api/";
const fetcher = async (endpoint) => {
  let payload;
  try {
    let response = await fetch(`${serverURL}${endpoint}`);
    payload = await response.json();
  } catch (err) {
    console.log(err);
    payload = { error: `Error has occured: ${err.message}` };
  }
  return payload;
};
export { fetcher };
