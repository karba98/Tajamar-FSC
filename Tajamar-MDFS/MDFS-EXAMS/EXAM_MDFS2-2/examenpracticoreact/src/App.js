import logo from "./logo.svg";
import "./App.css";
import Home from "./components/Home";
import Menu from "./routes/Menu";
import Router from "./routes/router";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";
function App() {
  return (
    <div>
      <Menu />
      <Router />
    </div>
  );
}

export default App;
