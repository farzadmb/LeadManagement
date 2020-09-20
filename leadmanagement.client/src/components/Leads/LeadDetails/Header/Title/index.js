import React from 'react';

const Title = (props) => {
    const { contact, time } = props;
    const { name } = contact;

    return (
        <React.Fragment>
            <div>
                {name.charAt(0)}
            </div>
            <div>
                <div>
                    {name.split(" ")[0]}
                </div>
                <div>
                    {time}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Title;