import {connect} from "react-redux";
import React from "react";
import styled from "styled-components";

const mapDispatchToProps = (dispatch) => {
    return {

    }
}

const Dropdown = styled.div`
`;

const LoadList = () => {
    return (
        <div>
            <form
                onSubmit={e => {
                    e.preventDefault();

                }}
                className="row"
            >
                <div className="">
                    <Dropdown className="row flex-edges">
                        <div className="col padding-small">
                            <div className="row flex-right margin-none">
                                <span className="padding-right-small">Select List...</span>
                                <select>
                                    <option value="Example">Example</option>
                                </select>
                                <div className=" padding-left-small">
                                    <input type="submit" value="Load" className="paper-btn btn-small" />
                                </div>
                            </div>
                        </div>
                    </Dropdown>
                </div>

            </form>
        </div>
    )
}

export default connect(null, mapDispatchToProps)(LoadList);
