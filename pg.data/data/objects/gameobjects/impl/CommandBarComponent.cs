﻿using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class CommandBarComponent : AbstractGameObjectType
    {
        public readonly StringParameter SelectedTextureName = new StringParameter("selected_texture_name");
        public readonly StringParameter BlankTextureName = new StringParameter("blank_texture_name");
        public readonly StringParameter IconTextureName = new StringParameter("icon_texture_name");
        public readonly StringParameter IconAlternateTextureName = new StringParameter("icon_alternate_texture_name");
        public readonly StringParameter MouseOverTextureName = new StringParameter("mouse_over_texture_name");
        public readonly StringParameter DisabledTextureName = new StringParameter("disabled_texture_name");
        public readonly StringParameter FlashTextureName = new StringParameter("flash_texture_name");
        public readonly StringParameter BarTextureName = new StringParameter("bar_texture_name");
        public readonly StringParameter BarOverlayName = new StringParameter("bar_overlay_name");
        public readonly StringParameter BuildTextureName = new StringParameter("build_texture_name");
        public readonly StringParameter ModelName = new StringParameter("model_name");
        public readonly StringParameter BoneName = new StringParameter("bone_name");
        public readonly StringParameter CursorTextureName = new StringParameter("cursor_texture_name");
        public readonly StringParameter FontName = new StringParameter("font_name");
        public readonly StringParameter AlternateFontName = new StringParameter("alternate_font_name");
        public readonly StringParameter TooltipText = new StringParameter("tooltip_text");
        public readonly StringParameter ClickSfx = new StringParameter("click_sfx");
        public readonly StringParameter MouseOverSfx = new StringParameter("mouse_over_sfx");
        public readonly StringParameter LowerEffectTextureName = new StringParameter("lower_effect_texture_name");
        public readonly StringParameter UpperEffectTextureName = new StringParameter("upper_effect_texture_name");
        public readonly StringParameter OverlayTextureName = new StringParameter("overlay_texture_name");
        public readonly StringParameter Overlay2TextureName = new StringParameter("overlay2_texture_name");
        public readonly StringParameter RightClickSfx = new StringParameter("right_click_sfx");
        public readonly StringParameter Type = new StringParameter("type");
        public readonly StringParameter Group = new StringParameter("group");
        public readonly StringParameter DragAndDrop = new StringParameter("drag_and_drop");
        public readonly StringParameter DragSelect = new StringParameter("drag_select");
        public readonly StringParameter Receptor = new StringParameter("receptor");
        public readonly StringParameter Toggle = new StringParameter("toggle");
        public readonly StringParameter Tab = new StringParameter("tab");
        public readonly StringParameter AssociatedText = new StringParameter("associated_text");
        public readonly StringParameter Hidden = new StringParameter("hidden");
        public readonly StringParameter Scale = new StringParameter("scale");
        public readonly StringParameter Color = new StringParameter("color");
        public readonly StringParameter TextColor = new StringParameter("text_color");
        public readonly StringParameter TextColor2 = new StringParameter("text_color2");
        public readonly StringParameter Size = new StringParameter("size");
        public readonly StringParameter ClearColor = new StringParameter("clear_color");
        public readonly StringParameter Disabled = new StringParameter("disabled");
        public readonly StringParameter SwapTexture = new StringParameter("swap_texture");
        public readonly StringParameter BaseLayer = new StringParameter("base_layer");
        public readonly StringParameter DrawAdditive = new StringParameter("draw_additive");
        public readonly StringParameter TextOffset = new StringParameter("text_offset");
        public readonly StringParameter TextOffset2 = new StringParameter("text_offset2");
        public readonly StringParameter Offset = new StringParameter("offset");
        public readonly StringParameter DefaultOffset = new StringParameter("default_offset");
        public readonly StringParameter DefaultOffsetWidescreen = new StringParameter("default_offset_widescreen");
        public readonly StringParameter IconOffset = new StringParameter("icon_offset");
        public readonly StringParameter MouseOverOffset = new StringParameter("mouse_over_offset");
        public readonly StringParameter DisabledOffset = new StringParameter("disabled_offset");
        public readonly StringParameter BuildDialOffset = new StringParameter("build_dial_offset");
        public readonly StringParameter BuildDial2Offset = new StringParameter("build_dial2_offset");
        public readonly StringParameter LowerEffectOffset = new StringParameter("lower_effect_offset");
        public readonly StringParameter UpperEffectOffset = new StringParameter("upper_effect_offset");
        public readonly StringParameter OverlayOffset = new StringParameter("overlay_offset");
        public readonly StringParameter Overlay2Offset = new StringParameter("overlay2_offset");
        public readonly StringParameter Editable = new StringParameter("editable");
        public readonly StringParameter MaxTextLength = new StringParameter("max_text_length");
        public readonly StringParameter BlinkRate = new StringParameter("blink_rate");
        public readonly StringParameter FontPointSize = new StringParameter("font_point_size");
        public readonly StringParameter TextOutline = new StringParameter("text_outline");
        public readonly StringParameter MaxTextWidth = new StringParameter("max_text_width");
        public readonly StringParameter Stackable = new StringParameter("stackable");
        public readonly StringParameter ModelOffsetX = new StringParameter("model_offset_x");
        public readonly StringParameter ModelOffsetY = new StringParameter("model_offset_y");
        public readonly StringParameter ScaleModelX = new StringParameter("scale_model_x");
        public readonly StringParameter ScaleModelY = new StringParameter("scale_model_y");
        public readonly StringParameter Collideable = new StringParameter("collideable");
        public readonly StringParameter TextEmboss = new StringParameter("text_emboss");
        public readonly StringParameter ShouldGhost = new StringParameter("should_ghost");
        public readonly StringParameter GhostBaseOnly = new StringParameter("ghost_base_only");
        public readonly StringParameter MaxBarLevel = new StringParameter("max_bar_level");
        public readonly StringParameter MaxBarColor = new StringParameter("max_bar_color");
        public readonly StringParameter CrossFade = new StringParameter("cross_fade");
        public readonly StringParameter LeftJustified = new StringParameter("left_justified");
        public readonly StringParameter RightJustified = new StringParameter("right_justified");
        public readonly StringParameter NoShell = new StringParameter("no_shell");
        public readonly StringParameter SnapDrag = new StringParameter("snap_drag");
        public readonly StringParameter SnapLocation = new StringParameter("snap_location");
        public readonly StringParameter BlinkDuration = new StringParameter("blink_duration");
        public readonly StringParameter ScaleDuration = new StringParameter("scale_duration");
        public readonly StringParameter OffsetRender = new StringParameter("offset_render");
        public readonly StringParameter BlinkFade = new StringParameter("blink_fade");
        public readonly StringParameter NoHiddenCollision = new StringParameter("no_hidden_collision");
        public readonly StringParameter ManualOffset = new StringParameter("manual_offset");
        public readonly StringParameter SelectedAlpha = new StringParameter("selected_alpha");
        public readonly StringParameter PixelAlign = new StringParameter("pixel_align");
        public readonly StringParameter CanDragStack = new StringParameter("can_drag_stack");
        public readonly StringParameter CanAnimate = new StringParameter("can_animate");
        public readonly StringParameter AnimFps = new StringParameter("anim_fps");
        public readonly StringParameter LoopAnim = new StringParameter("loop_anim");
        public readonly StringParameter SmoothBar = new StringParameter("smooth_bar");
        public readonly StringParameter OutlinedBar = new StringParameter("outlined_bar");
        public readonly StringParameter DragBack = new StringParameter("drag_back");
        public readonly StringParameter LowerEffectAdditive = new StringParameter("lower_effect_additive");
        public readonly StringParameter UpperEffectAdditive = new StringParameter("upper_effect_additive");
        public readonly StringParameter ClickShift = new StringParameter("click_shift");
        public readonly StringParameter TutorialScene = new StringParameter("tutorial_scene");
        public readonly StringParameter DialogScene = new StringParameter("dialog_scene");
        public readonly StringParameter ShouldRenderAtDragPos = new StringParameter("should_render_at_drag_pos");
        public readonly StringParameter DisableDarken = new StringParameter("disable_darken");
        public readonly StringParameter AnimateBack = new StringParameter("animate_back");
        public readonly StringParameter AnimateUpperEffec = new StringParameter("animate_upper_effect");
    }
}