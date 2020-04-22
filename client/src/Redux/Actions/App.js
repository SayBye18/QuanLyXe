import { CHANGE_COLOR } from '../Constants/App'

export const changeColor = (index) => dispatch => {
    dispatch({
        type: CHANGE_COLOR,
        payload: index
    })
    //dispatch action
}