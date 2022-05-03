import React, { Component } from "react";

export default class Delete extends Component {
  render() {
    return (
      <div>
        <a>{this.props.id}</a>
      </div>
    );
  }
}
