import React, { Component } from 'react';
import styled from 'styled-components';

import AddTodo from './AddTodo';
import TodoList from './TodoList';
import SaveList from './SaveList';
import LoadList from './LoadList';

const Container = styled.div`
  background-color: #f1f1f1;
  margin: 0;
  min-height: 100vh;
`;

const Paper = styled.div`
  width: 480px !important;
  background-color: white;
`;

// Main app structure
class App extends Component {

  /* fetch example start */
  componentDidMount() {
    const apiUrl = 'http://localhost:51255/api/todo';
    fetch(apiUrl)
    .then((response) => response.json())
    .then(json => console.log(json))
  }
  /* fetch example start */

  render() {
    return (
      <Container className="row flex-center flex-middle">
        <Paper className="border border-primary padding-large margin-large no-responsive">
          <h3 className="margin-small">PaperTodo</h3>
          <AddTodo />
          <TodoList />
          <SaveList />
          <LoadList />
        </Paper>
      </Container>
    );
  }
}

export default App;
