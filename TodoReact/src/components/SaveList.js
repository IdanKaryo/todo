import React from "react";


class SaveList extends React.Component {    

    render() {
        return (
                    <div>
                        <form
                            onSubmit={e => {
                                e.preventDefault();
                                const requestOptions = {
                                    method: 'PUT',
                                    headers: { 'Content-Type': 'application/json' },
                                    body: JSON.stringify({ name: 'List 1', list: null})
                                };
                                  const apiUrl = 'http://localhost:51255/api/todo';
                                  
                                  fetch(apiUrl, requestOptions)
                                  .then((response) => response.json())
                                  .then(json => console.log(json))
                            }}
                            className="row"
                        >
                            <div className="col padding-right-small">
                                <input type="text" placeholder="List Name" />
                            </div>
                            <div className="col padding-left-small">
                                <input type="submit" value="Save" className="paper-btn btn-small" />
                            </div>
                        </form>
                    </div>
                )
    }
  }
  export default SaveList;