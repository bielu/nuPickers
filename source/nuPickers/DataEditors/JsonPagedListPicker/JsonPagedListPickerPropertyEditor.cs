﻿using ClientDependency.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace nuPickers.DataEditors.JsonPagedListPicker
{
    // EDITOR UI
    [DataEditor(PropertyEditorConstants.JsonPagedListPickerAlias, "nuPickers: Json PagedList Picker", EmbeddedResource.EmbeddedResource.ROOT_URL + "PagedListPicker/PagedListPickerEditor.html", ValueType = "TEXT")]
    [PropertyEditorAsset(ClientDependencyType.Css, EmbeddedResource.EmbeddedResource.ROOT_URL + "ListPicker/ListPickerEditor.css" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Css, EmbeddedResource.EmbeddedResource.ROOT_URL + "PagedListPicker/PagedListPickerEditor.css" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "ListPicker/ListPickerEditorController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "ListPicker/ListPickerEditorDirectives.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "PagedListPicker/PagedListPickerEditorController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]

    // RESOURCES (all are referenced as EditorResource consumes the others)
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "Editor/EditorResource.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "DataSource/DataSourceResource.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingResource.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatResource.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]

    // CONFIG
    [PropertyEditorAsset(ClientDependencyType.Css, EmbeddedResource.EmbeddedResource.ROOT_URL + "PropertyEditor/PropertyEditorConfig.css" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "JsonDataSource/JsonDataSourceConfigController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "CustomLabel/CustomLabelConfigController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingConfigController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfigController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    public class JsonPagedListPickerPropertyEditor : DataEditor
    {
        protected override IConfigurationEditor CreateConfigurationEditor() => new JsonPagedListPickerConfigurationEditor();

        public JsonPagedListPickerPropertyEditor(ILogger logger) : base(logger)
        {
        }
    }
}