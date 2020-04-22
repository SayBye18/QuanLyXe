import { CHANGE_COLOR } from '../Constants/App'

const initialState = {
    indexColor: "black",
    arr: [
        {
            id: 1,
            name: "nam"
        },
        {
            id: 2,
            name: "trung"
        },
        {
            id: 3,
            name: "sơn"
        },
    ]
}

export default (state = initialState, action) => {
    switch (action.type) {
        case CHANGE_COLOR:
            {
                return { ...state, indexColor: action.payload }
            }

        default:
            return { ...state }
    }
}