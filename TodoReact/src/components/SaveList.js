import React from "react";


class SaveList extends React.Component {    

    render() {
        return (
                    <div>
                        <form
                            onSubmit={e => {
                                e.preventDefault();
            
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