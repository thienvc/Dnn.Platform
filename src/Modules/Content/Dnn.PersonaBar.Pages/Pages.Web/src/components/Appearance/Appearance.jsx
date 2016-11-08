import React, {Component, PropTypes} from "react";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import GridSystem from "dnn-grid-system";
import GridCell from "dnn-grid-cell";
import Label from "dnn-label";
import localization from "../../localization";
import ThemeSelector from "./ThemeSelector/ThemeSelector";
import ThemeActions from "../../actions/themeActions";

class Appearance extends Component {

    componentWillMount() {
        this.props.onRetrieveThemes();
    }

    render() {        
        return (
            <GridSystem>
                <GridCell columnSize={100}>
                    <ThemeSelector />
                </GridCell>
                <GridCell columnSize={100}>
                    <Label 
                        label={localization.get("Layout")} 
                        tooltipMessage={localization.get("AddTooltipHere_TODO")} />
                </GridCell>
                <GridCell columnSize={100}>
                    <Label 
                        label={localization.get("PageContainer")} 
                        tooltipMessage={localization.get("AddTooltipHere_TODO")} />
                </GridCell>
            </GridSystem>
        );
    }
}

Appearance.propTypes = {
    page: PropTypes.object.isRequired,
    onRetrieveThemes: PropTypes.func.isRequired,
    themes: PropTypes.array.isRequired
};

function mapStateToProps(state) {
    return {
        themes: state.theme.themes
    };
}

function mapDispatchToProps(dispatch) {
    return bindActionCreators ({
        onRetrieveThemes: ThemeActions.retrieveThemes
    }, dispatch);
}

export default connect(mapStateToProps, mapDispatchToProps)(Appearance);
