using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200075F RID: 1887
	public class Pot : GridItem
	{
		// Token: 0x0600AB2C RID: 43820 RVA: 0x002ADC10 File Offset: 0x002ABE10
		// Note: this type is marked as 'beforefieldinit'.
		static Pot()
		{
			Il2CppClassPointerStore<Pot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Pot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot>.NativeClassPtr);
			Pot.NativeFieldInfoPtr_DryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DryThreshold");
			Pot.NativeFieldInfoPtr_WaterloggedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterloggedThreshold");
			Pot.NativeFieldInfoPtr_ROTATION_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "ROTATION_SPEED");
			Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MAX_CAMERA_DISTANCE");
			Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MIN_CAMERA_DISTANCE");
			Pot.NativeFieldInfoPtr_ModelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "ModelTransform");
			Pot.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObj");
			Pot.NativeFieldInfoPtr_PourableStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PourableStartPoint");
			Pot.NativeFieldInfoPtr_SeedStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SeedStartPoint");
			Pot.NativeFieldInfoPtr_SeedRestingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SeedRestingPoint");
			Pot.NativeFieldInfoPtr_WaterLoggedVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLoggedVisuals");
			Pot.NativeFieldInfoPtr_LookAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LookAtPoint");
			Pot.NativeFieldInfoPtr_AdditivesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AdditivesContainer");
			Pot.NativeFieldInfoPtr_PlantContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PlantContainer");
			Pot.NativeFieldInfoPtr_IntObjLabel_Low = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObjLabel_Low");
			Pot.NativeFieldInfoPtr_IntObjLabel_High = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObjLabel_High");
			Pot.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "uiPoint");
			Pot.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "configReplicator");
			Pot.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "accessPoints");
			Pot.NativeFieldInfoPtr_TaskBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "TaskBounds");
			Pot.NativeFieldInfoPtr_SoilCover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilCover");
			Pot.NativeFieldInfoPtr_LeafDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LeafDropPoint");
			Pot.NativeFieldInfoPtr_PoofParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PoofParticles");
			Pot.NativeFieldInfoPtr_PoofSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PoofSound");
			Pot.NativeFieldInfoPtr_WaterCanvasContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterCanvasContainer");
			Pot.NativeFieldInfoPtr_WaterLevelCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelCanvas");
			Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelCanvasGroup");
			Pot.NativeFieldInfoPtr_WaterLevelSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelSlider");
			Pot.NativeFieldInfoPtr_NoWaterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NoWaterIcon");
			Pot.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WorldspaceUIPrefab");
			Pot.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "typeIcon");
			Pot.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "CameraContainer");
			Pot.NativeFieldInfoPtr_MidshotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MidshotPosition");
			Pot.NativeFieldInfoPtr_CloseupPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "CloseupPosition");
			Pot.NativeFieldInfoPtr_FullshotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "FullshotPosition");
			Pot.NativeFieldInfoPtr_BirdsEyePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "BirdsEyePosition");
			Pot.NativeFieldInfoPtr_AutoRotateCameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AutoRotateCameraContainer");
			Pot.NativeFieldInfoPtr_Dirt_Flat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Dirt_Flat");
			Pot.NativeFieldInfoPtr_Dirt_Parted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Dirt_Parted");
			Pot.NativeFieldInfoPtr_SoilChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilChunks");
			Pot.NativeFieldInfoPtr_DirtRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtRenderers");
			Pot.NativeFieldInfoPtr_PotRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PotRadius");
			Pot.NativeFieldInfoPtr_YieldMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "YieldMultiplier");
			Pot.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "GrowSpeedMultiplier");
			Pot.NativeFieldInfoPtr_MoistureDrainMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MoistureDrainMultiplier");
			Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AlignLeafDropToPlayer");
			Pot.NativeFieldInfoPtr_SoilCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilCapacity");
			Pot.NativeFieldInfoPtr_WaterCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterCapacity");
			Pot.NativeFieldInfoPtr_WaterDrainPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterDrainPerHour");
			Pot.NativeFieldInfoPtr_DirtMinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtMinScale");
			Pot.NativeFieldInfoPtr_DirtMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtMaxScale");
			Pot.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Target");
			Pot.NativeFieldInfoPtr_LightSourceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LightSourceOverride");
			Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<SoilLevel>k__BackingField");
			Pot.NativeFieldInfoPtr__SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<SoilID>k__BackingField");
			Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<RemainingSoilUses>k__BackingField");
			Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<WaterLevel>k__BackingField");
			Pot.NativeFieldInfoPtr__Plant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<Plant>k__BackingField");
			Pot.NativeFieldInfoPtr_AppliedAdditives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AppliedAdditives");
			Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<potConfiguration>k__BackingField");
			Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Pot.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<InputSlots>k__BackingField");
			Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<OutputSlots>k__BackingField");
			Pot.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<Selectable>k__BackingField");
			Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			Pot.NativeFieldInfoPtr_intObjSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "intObjSetThisFrame");
			Pot.NativeFieldInfoPtr_outputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "outputSlot");
			Pot.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "rotation");
			Pot.NativeFieldInfoPtr_rotationOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "rotationOverridden");
			Pot.NativeFieldInfoPtr_appliedSoilDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "appliedSoilDefinition");
			Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<SoilLevel>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<SoilID>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<RemainingSoilUses>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<WaterLevel>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Pot.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted");
			Pot.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted");
			Pot.NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684347);
			Pot.NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684348);
			Pot.NativeMethodInfoPtr_get_SoilID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684349);
			Pot.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684350);
			Pot.NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684351);
			Pot.NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684352);
			Pot.NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684353);
			Pot.NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684354);
			Pot.NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684355);
			Pot.NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684356);
			Pot.NativeMethodInfoPtr_get_Plant_Public_get_Plant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684357);
			Pot.NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684358);
			Pot.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684359);
			Pot.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684360);
			Pot.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684361);
			Pot.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684362);
			Pot.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684363);
			Pot.NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684364);
			Pot.NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684365);
			Pot.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684366);
			Pot.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684367);
			Pot.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684368);
			Pot.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684369);
			Pot.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684370);
			Pot.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684371);
			Pot.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684372);
			Pot.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684373);
			Pot.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684374);
			Pot.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684375);
			Pot.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684376);
			Pot.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684377);
			Pot.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684378);
			Pot.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684379);
			Pot.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684380);
			Pot.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684381);
			Pot.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684382);
			Pot.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684383);
			Pot.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684384);
			Pot.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684385);
			Pot.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684386);
			Pot.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684387);
			Pot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684388);
			Pot.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684389);
			Pot.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684390);
			Pot.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684391);
			Pot.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684392);
			Pot.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684393);
			Pot.NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684394);
			Pot.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684395);
			Pot.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684396);
			Pot.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684397);
			Pot.NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684398);
			Pot.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684399);
			Pot.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684400);
			Pot.NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684401);
			Pot.NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684402);
			Pot.NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684403);
			Pot.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684404);
			Pot.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684405);
			Pot.NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684406);
			Pot.NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684407);
			Pot.NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684408);
			Pot.NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684409);
			Pot.NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684410);
			Pot.NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684411);
			Pot.NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684412);
			Pot.NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684413);
			Pot.NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684414);
			Pot.NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684415);
			Pot.NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684416);
			Pot.NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684417);
			Pot.NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684418);
			Pot.NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684419);
			Pot.NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684420);
			Pot.NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684421);
			Pot.NativeMethodInfoPtr_RandomizeTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684422);
			Pot.NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684423);
			Pot.NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684424);
			Pot.NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684425);
			Pot.NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684426);
			Pot.NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684427);
			Pot.NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684428);
			Pot.NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684429);
			Pot.NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684430);
			Pot.NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684431);
			Pot.NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684432);
			Pot.NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684433);
			Pot.NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684434);
			Pot.NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684435);
			Pot.NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684436);
			Pot.NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684437);
			Pot.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684438);
			Pot.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684439);
			Pot.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684440);
			Pot.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684441);
			Pot.NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684442);
			Pot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684443);
			Pot.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684444);
			Pot.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684445);
			Pot.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684446);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684447);
			Pot.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684448);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684449);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684450);
			Pot.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684451);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684452);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684453);
			Pot.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684454);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684455);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684456);
			Pot.NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684457);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684458);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684459);
			Pot.NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684460);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684461);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684462);
			Pot.NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684463);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684464);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684465);
			Pot.NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684466);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684467);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684468);
			Pot.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684469);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684470);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684471);
			Pot.NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684472);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684473);
			Pot.NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684474);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684475);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684476);
			Pot.NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684477);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684478);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684479);
			Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684480);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684481);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684482);
			Pot.NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684483);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684484);
			Pot.NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684485);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684486);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684487);
			Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684488);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684489);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684490);
			Pot.NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684491);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684492);
			Pot.NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684493);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684494);
			Pot.NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684495);
			Pot.NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684496);
			Pot.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684497);
			Pot.NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684498);
			Pot.NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684499);
			Pot.NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684500);
			Pot.NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684501);
			Pot.NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684502);
			Pot.NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684503);
			Pot.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684504);
			Pot.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684505);
			Pot.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684506);
			Pot.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684507);
			Pot.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684508);
			Pot.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684509);
			Pot.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100684510);
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600AB2D RID: 43821 RVA: 0x002AEF78 File Offset: 0x002AD178
		// (set) Token: 0x0600AB2E RID: 43822 RVA: 0x002AEFB4 File Offset: 0x002AD1B4
		public unsafe float SoilLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 297476, RefRangeEnd = 297481, XrefRangeStart = 297476, XrefRangeEnd = 297476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 297488, RefRangeEnd = 297492, XrefRangeStart = 297481, XrefRangeEnd = 297488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600AB2F RID: 43823 RVA: 0x002AEFF4 File Offset: 0x002AD1F4
		// (set) Token: 0x0600AB30 RID: 43824 RVA: 0x002AF02C File Offset: 0x002AD22C
		public unsafe string SoilID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 187600, RefRangeEnd = 187604, XrefRangeStart = 187600, XrefRangeEnd = 187604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_SoilID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 297500, RefRangeEnd = 297504, XrefRangeStart = 297492, XrefRangeEnd = 297500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600AB31 RID: 43825 RVA: 0x002AF070 File Offset: 0x002AD270
		// (set) Token: 0x0600AB32 RID: 43826 RVA: 0x002AF0AC File Offset: 0x002AD2AC
		public unsafe int RemainingSoilUses
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 297511, RefRangeEnd = 297515, XrefRangeStart = 297504, XrefRangeEnd = 297511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x002AF0EC File Offset: 0x002AD2EC
		// (set) Token: 0x0600AB34 RID: 43828 RVA: 0x002AF128 File Offset: 0x002AD328
		public unsafe float WaterLevel
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 297515, RefRangeEnd = 297517, XrefRangeStart = 297515, XrefRangeEnd = 297515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 297524, RefRangeEnd = 297530, XrefRangeStart = 297517, XrefRangeEnd = 297524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600AB35 RID: 43829 RVA: 0x002AF168 File Offset: 0x002AD368
		public unsafe float NormalizedWaterLevel
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 297530, RefRangeEnd = 297538, XrefRangeStart = 297530, XrefRangeEnd = 297530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600AB36 RID: 43830 RVA: 0x002AF1A4 File Offset: 0x002AD3A4
		public unsafe bool IsFilledWithSoil
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 297538, RefRangeEnd = 297546, XrefRangeStart = 297538, XrefRangeEnd = 297538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600AB37 RID: 43831 RVA: 0x002AF1E0 File Offset: 0x002AD3E0
		// (set) Token: 0x0600AB38 RID: 43832 RVA: 0x002AF220 File Offset: 0x002AD420
		public unsafe Plant Plant
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 97310, RefRangeEnd = 97315, XrefRangeStart = 97310, XrefRangeEnd = 97315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Plant_Public_get_Plant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600AB39 RID: 43833 RVA: 0x002AF264 File Offset: 0x002AD464
		// (set) Token: 0x0600AB3A RID: 43834 RVA: 0x002AF2A4 File Offset: 0x002AD4A4
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 188282, RefRangeEnd = 188290, XrefRangeStart = 188282, XrefRangeEnd = 188290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 297554, RefRangeEnd = 297556, XrefRangeStart = 297546, XrefRangeEnd = 297554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x002AF2E8 File Offset: 0x002AD4E8
		// (set) Token: 0x0600AB3C RID: 43836 RVA: 0x002AF328 File Offset: 0x002AD528
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 188302, RefRangeEnd = 188309, XrefRangeStart = 188302, XrefRangeEnd = 188309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297556, XrefRangeEnd = 297564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600AB3D RID: 43837 RVA: 0x002AF36C File Offset: 0x002AD56C
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 187604, RefRangeEnd = 187629, XrefRangeStart = 187604, XrefRangeEnd = 187629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600AB3E RID: 43838 RVA: 0x002AF3AC File Offset: 0x002AD5AC
		// (set) Token: 0x0600AB3F RID: 43839 RVA: 0x002AF3EC File Offset: 0x002AD5EC
		public unsafe PotConfiguration potConfiguration
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 187604, RefRangeEnd = 187629, XrefRangeStart = 187604, XrefRangeEnd = 187629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfiguration>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600AB40 RID: 43840 RVA: 0x002AF430 File Offset: 0x002AD630
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 171183, RefRangeEnd = 171190, XrefRangeStart = 171183, XrefRangeEnd = 171190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600AB41 RID: 43841 RVA: 0x002AF470 File Offset: 0x002AD670
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600AB42 RID: 43842 RVA: 0x002AF4AC File Offset: 0x002AD6AC
		// (set) Token: 0x0600AB43 RID: 43843 RVA: 0x002AF4EC File Offset: 0x002AD6EC
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 188913, RefRangeEnd = 188924, XrefRangeStart = 188913, XrefRangeEnd = 188924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297564, XrefRangeEnd = 297565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600AB44 RID: 43844 RVA: 0x002AF530 File Offset: 0x002AD730
		// (set) Token: 0x0600AB45 RID: 43845 RVA: 0x002AF570 File Offset: 0x002AD770
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 297573, RefRangeEnd = 297575, XrefRangeStart = 297565, XrefRangeEnd = 297573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600AB46 RID: 43846 RVA: 0x002AF5B4 File Offset: 0x002AD7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297575, XrefRangeEnd = 297597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600AB47 RID: 43847 RVA: 0x002AF5F8 File Offset: 0x002AD7F8
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600AB48 RID: 43848 RVA: 0x002AF638 File Offset: 0x002AD838
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 51237, RefRangeEnd = 51239, XrefRangeStart = 51237, XrefRangeEnd = 51239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600AB49 RID: 43849 RVA: 0x002AF678 File Offset: 0x002AD878
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 171181, RefRangeEnd = 171182, XrefRangeStart = 171181, XrefRangeEnd = 171182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x002AF6B8 File Offset: 0x002AD8B8
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x002AF6F4 File Offset: 0x002AD8F4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x002AF72C File Offset: 0x002AD92C
		// (set) Token: 0x0600AB4D RID: 43853 RVA: 0x002AF76C File Offset: 0x002AD96C
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297597, XrefRangeEnd = 297598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600AB4E RID: 43854 RVA: 0x002AF7B0 File Offset: 0x002AD9B0
		// (set) Token: 0x0600AB4F RID: 43855 RVA: 0x002AF7F0 File Offset: 0x002AD9F0
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297598, XrefRangeEnd = 297599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600AB50 RID: 43856 RVA: 0x002AF834 File Offset: 0x002ADA34
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 171181, RefRangeEnd = 171182, XrefRangeStart = 171181, XrefRangeEnd = 171182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600AB51 RID: 43857 RVA: 0x002AF874 File Offset: 0x002ADA74
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 140356, RefRangeEnd = 140374, XrefRangeStart = 140356, XrefRangeEnd = 140374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600AB52 RID: 43858 RVA: 0x002AF8B4 File Offset: 0x002ADAB4
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600AB53 RID: 43859 RVA: 0x002AF8F0 File Offset: 0x002ADAF0
		// (set) Token: 0x0600AB54 RID: 43860 RVA: 0x002AF92C File Offset: 0x002ADB2C
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x002AF96C File Offset: 0x002ADB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297599, XrefRangeEnd = 297605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x002AF9A8 File Offset: 0x002ADBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297605, XrefRangeEnd = 297616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x002AF9E4 File Offset: 0x002ADBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297616, XrefRangeEnd = 297656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x002AFA34 File Offset: 0x002ADC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297656, XrefRangeEnd = 297669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x002AFA78 File Offset: 0x002ADC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297669, XrefRangeEnd = 297714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x002AFB08 File Offset: 0x002ADD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297714, XrefRangeEnd = 297760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref callOnServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB5B RID: 43867 RVA: 0x002AFB54 File Offset: 0x002ADD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297760, XrefRangeEnd = 297792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB5C RID: 43868 RVA: 0x002AFB90 File Offset: 0x002ADD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297850, RefRangeEnd = 297851, XrefRangeStart = 297792, XrefRangeEnd = 297850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB5D RID: 43869 RVA: 0x002AFBC4 File Offset: 0x002ADDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297851, XrefRangeEnd = 297857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB5E RID: 43870 RVA: 0x002AFBF8 File Offset: 0x002ADDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297857, XrefRangeEnd = 297878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeSkipped(int minsSkippped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref minsSkippped;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB5F RID: 43871 RVA: 0x002AFC38 File Offset: 0x002ADE38
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 297881, RefRangeEnd = 297889, XrefRangeStart = 297878, XrefRangeEnd = 297881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInteraction(string message, InteractableObject.EInteractableState state, bool useHighLabelPos = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref useHighLabelPos;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB60 RID: 43872 RVA: 0x002AFC98 File Offset: 0x002ADE98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 297911, RefRangeEnd = 297914, XrefRangeStart = 297889, XrefRangeEnd = 297911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionCameraContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x002AFCCC File Offset: 0x002ADECC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 297936, RefRangeEnd = 297942, XrefRangeStart = 297914, XrefRangeEnd = 297936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB62 RID: 43874 RVA: 0x002AFD10 File Offset: 0x002ADF10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297964, RefRangeEnd = 297966, XrefRangeStart = 297942, XrefRangeEnd = 297964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB63 RID: 43875 RVA: 0x002AFD54 File Offset: 0x002ADF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297966, XrefRangeEnd = 297987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x002AFD90 File Offset: 0x002ADF90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297998, RefRangeEnd = 297999, XrefRangeStart = 297987, XrefRangeEnd = 297998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &growSpeedMultiplier;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x002AFDDC File Offset: 0x002ADFDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298009, RefRangeEnd = 298010, XrefRangeStart = 297999, XrefRangeEnd = 298009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAcceptSeed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x002AFE34 File Offset: 0x002AE034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298020, RefRangeEnd = 298022, XrefRangeStart = 298010, XrefRangeEnd = 298020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyForHarvest(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x002AFE8C File Offset: 0x002AE08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298022, XrefRangeEnd = 298039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x002AFEF0 File Offset: 0x002AE0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298039, RefRangeEnd = 298040, XrefRangeStart = 298039, XrefRangeEnd = 298039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideRotation(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref angle;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x002AFF30 File Offset: 0x002AE130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298040, RefRangeEnd = 298041, XrefRangeStart = 298040, XrefRangeEnd = 298040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetCameraPosition(Pot.ECameraPosition pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x002AFF7C File Offset: 0x002AE17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298041, XrefRangeEnd = 298043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddSoil(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x002AFFC8 File Offset: 0x002AE1C8
		[CallerCount(0)]
		public unsafe void SoilLevelChanged(float _prev, float _new, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _prev;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _new;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref asServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x002B0024 File Offset: 0x002AE224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298043, XrefRangeEnd = 298045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSoilScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x002B0060 File Offset: 0x002AE260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298045, XrefRangeEnd = 298052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSoilID(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB6E RID: 43886 RVA: 0x002B00B0 File Offset: 0x002AE2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298052, XrefRangeEnd = 298053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSoilUses(int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref uses;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB6F RID: 43887 RVA: 0x002B00FC File Offset: 0x002AE2FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298066, RefRangeEnd = 298068, XrefRangeStart = 298053, XrefRangeEnd = 298066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushSoilDataToServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB70 RID: 43888 RVA: 0x002B0130 File Offset: 0x002AE330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298068, XrefRangeEnd = 298081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSoilData(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref soilUses;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB71 RID: 43889 RVA: 0x002B0190 File Offset: 0x002AE390
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 298089, RefRangeEnd = 298096, XrefRangeStart = 298081, XrefRangeEnd = 298089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilState(Pot.ESoilState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB72 RID: 43890 RVA: 0x002B01D0 File Offset: 0x002AE3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298096, XrefRangeEnd = 298121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSoilMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB73 RID: 43891 RVA: 0x002B020C File Offset: 0x002AE40C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 298126, RefRangeEnd = 298132, XrefRangeStart = 298121, XrefRangeEnd = 298126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeWaterAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB74 RID: 43892 RVA: 0x002B024C File Offset: 0x002AE44C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298142, RefRangeEnd = 298144, XrefRangeStart = 298132, XrefRangeEnd = 298142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushWaterDataToServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB75 RID: 43893 RVA: 0x002B0280 File Offset: 0x002AE480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298144, XrefRangeEnd = 298154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWaterData(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref waterLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB76 RID: 43894 RVA: 0x002B02C0 File Offset: 0x002AE4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298154, XrefRangeEnd = 298157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaterLevelChanged(float _prev, float _new, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _prev;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _new;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref asServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB77 RID: 43895 RVA: 0x002B031C File Offset: 0x002AE51C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298160, RefRangeEnd = 298164, XrefRangeStart = 298157, XrefRangeEnd = 298160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB78 RID: 43896 RVA: 0x002B035C File Offset: 0x002AE55C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298175, RefRangeEnd = 298179, XrefRangeStart = 298164, XrefRangeEnd = 298175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RandomizeTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x002B0390 File Offset: 0x002AE590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298201, RefRangeEnd = 298202, XrefRangeStart = 298179, XrefRangeEnd = 298201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAdditive(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB7A RID: 43898 RVA: 0x002B03E0 File Offset: 0x002AE5E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 298246, RefRangeEnd = 298253, XrefRangeStart = 298202, XrefRangeEnd = 298246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAdditive(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB7B RID: 43899 RVA: 0x002B0444 File Offset: 0x002AE644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298267, RefRangeEnd = 298268, XrefRangeStart = 298253, XrefRangeEnd = 298267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAdditiveGrowthMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x002B0480 File Offset: 0x002AE680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298268, XrefRangeEnd = 298282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetYieldChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x002B04BC File Offset: 0x002AE6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298282, XrefRangeEnd = 298296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetQualityChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x002B04F8 File Offset: 0x002AE6F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298311, RefRangeEnd = 298313, XrefRangeStart = 298296, XrefRangeEnd = 298311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Additive GetAdditive(string additiveName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Additive>(intPtr2) : null;
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x002B0548 File Offset: 0x002AE748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298334, RefRangeEnd = 298335, XrefRangeStart = 298313, XrefRangeEnd = 298334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullyGrowPlant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x002B057C File Offset: 0x002AE77C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298359, RefRangeEnd = 298361, XrefRangeStart = 298335, XrefRangeEnd = 298359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref qualityLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x002B05E8 File Offset: 0x002AE7E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 298409, RefRangeEnd = 298414, XrefRangeStart = 298361, XrefRangeEnd = 298409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantSeed(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref qualityLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x002B0668 File Offset: 0x002AE868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298414, XrefRangeEnd = 298424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrowProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref progress;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB83 RID: 43907 RVA: 0x002B06A8 File Offset: 0x002AE8A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298453, RefRangeEnd = 298457, XrefRangeStart = 298424, XrefRangeEnd = 298453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref qualityLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB84 RID: 43908 RVA: 0x002B0714 File Offset: 0x002AE914
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298503, RefRangeEnd = 298507, XrefRangeStart = 298457, XrefRangeEnd = 298503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHarvestableActive(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB85 RID: 43909 RVA: 0x002B0774 File Offset: 0x002AE974
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 298539, RefRangeEnd = 298544, XrefRangeStart = 298507, XrefRangeEnd = 298539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHarvestableActive_Local(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB86 RID: 43910 RVA: 0x002B07C0 File Offset: 0x002AE9C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298567, RefRangeEnd = 298569, XrefRangeStart = 298544, XrefRangeEnd = 298567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHarvestableActive(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x002B080C File Offset: 0x002AEA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298569, XrefRangeEnd = 298570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHarvestableActive_Local(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x002B0858 File Offset: 0x002AEA58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298597, RefRangeEnd = 298598, XrefRangeStart = 298570, XrefRangeEnd = 298597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
		}

		// Token: 0x0600AB89 RID: 43913 RVA: 0x002B0898 File Offset: 0x002AEA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298598, XrefRangeEnd = 298602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB8A RID: 43914 RVA: 0x002B08CC File Offset: 0x002AEACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298602, XrefRangeEnd = 298632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x0600AB8B RID: 43915 RVA: 0x002B0918 File Offset: 0x002AEB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298632, XrefRangeEnd = 298636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicSaveData>(intPtr2) : null;
		}

		// Token: 0x0600AB8C RID: 43916 RVA: 0x002B0964 File Offset: 0x002AEB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298636, XrefRangeEnd = 298645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadPlant(PlantData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB8D RID: 43917 RVA: 0x002B09B4 File Offset: 0x002AEBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298645, XrefRangeEnd = 298677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB8E RID: 43918 RVA: 0x002B09F0 File Offset: 0x002AEBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298677, XrefRangeEnd = 298862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB8F RID: 43919 RVA: 0x002B0A2C File Offset: 0x002AEC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298862, XrefRangeEnd = 298863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB90 RID: 43920 RVA: 0x002B0A68 File Offset: 0x002AEC68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x002B0AA4 File Offset: 0x002AECA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298863, XrefRangeEnd = 298873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x002B0AE8 File Offset: 0x002AECE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297573, RefRangeEnd = 297575, XrefRangeStart = 297573, XrefRangeEnd = 297575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB93 RID: 43923 RVA: 0x002B0B2C File Offset: 0x002AED2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298873, XrefRangeEnd = 298877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB94 RID: 43924 RVA: 0x002B0B90 File Offset: 0x002AED90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298877, XrefRangeEnd = 298887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x002B0BD4 File Offset: 0x002AEDD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298911, RefRangeEnd = 298913, XrefRangeStart = 298887, XrefRangeEnd = 298911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x002B0C18 File Offset: 0x002AEE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298913, XrefRangeEnd = 298917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x002B0C7C File Offset: 0x002AEE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298917, XrefRangeEnd = 298927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x002B0CC0 File Offset: 0x002AEEC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297554, RefRangeEnd = 297556, XrefRangeStart = 297554, XrefRangeEnd = 297556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB99 RID: 43929 RVA: 0x002B0D04 File Offset: 0x002AEF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298927, XrefRangeEnd = 298931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB9A RID: 43930 RVA: 0x002B0D68 File Offset: 0x002AEF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298931, XrefRangeEnd = 298940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ResetPot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB9B RID: 43931 RVA: 0x002B0D9C File Offset: 0x002AEF9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298981, RefRangeEnd = 298983, XrefRangeStart = 298940, XrefRangeEnd = 298981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ResetPot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB9C RID: 43932 RVA: 0x002B0DD8 File Offset: 0x002AEFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298983, XrefRangeEnd = 298986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ResetPot_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB9D RID: 43933 RVA: 0x002B0E28 File Offset: 0x002AF028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref soilUses;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x002B0E88 File Offset: 0x002AF088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298986, XrefRangeEnd = 298998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref soilUses;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x002B0EE8 File Offset: 0x002AF0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298998, XrefRangeEnd = 299015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSoilData_3104499779(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x002B0F4C File Offset: 0x002AF14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWaterData_431000436(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref waterLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x002B0F8C File Offset: 0x002AF18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299015, XrefRangeEnd = 299016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWaterData_431000436(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref waterLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA2 RID: 43938 RVA: 0x002B0FCC File Offset: 0x002AF1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299016, XrefRangeEnd = 299019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWaterData_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA3 RID: 43939 RVA: 0x002B1030 File Offset: 0x002AF230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299019, XrefRangeEnd = 299030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x002B1080 File Offset: 0x002AF280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299030, XrefRangeEnd = 299031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA5 RID: 43941 RVA: 0x002B10D0 File Offset: 0x002AF2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299031, XrefRangeEnd = 299035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAdditive_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x002B1134 File Offset: 0x002AF334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299035, XrefRangeEnd = 299046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x002B1198 File Offset: 0x002AF398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299094, RefRangeEnd = 299097, XrefRangeStart = 299046, XrefRangeEnd = 299094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x002B11FC File Offset: 0x002AF3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299097, XrefRangeEnd = 299101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x002B124C File Offset: 0x002AF44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299101, XrefRangeEnd = 299112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x002B12B0 File Offset: 0x002AF4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299112, XrefRangeEnd = 299116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABAB RID: 43947 RVA: 0x002B1300 File Offset: 0x002AF500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299116, XrefRangeEnd = 299125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_FullyGrowPlant_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x002B1334 File Offset: 0x002AF534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299136, RefRangeEnd = 299138, XrefRangeStart = 299125, XrefRangeEnd = 299136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___FullyGrowPlant_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABAD RID: 43949 RVA: 0x002B1368 File Offset: 0x002AF568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299138, XrefRangeEnd = 299141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_FullyGrowPlant_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x002B13B8 File Offset: 0x002AF5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299141, XrefRangeEnd = 299154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref qualityLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x002B1424 File Offset: 0x002AF624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299154, XrefRangeEnd = 299155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref qualityLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x002B1490 File Offset: 0x002AF690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299155, XrefRangeEnd = 299162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlantSeed_2530605204(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x002B14F4 File Offset: 0x002AF6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299162, XrefRangeEnd = 299175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref qualityLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x002B1574 File Offset: 0x002AF774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299175, XrefRangeEnd = 299176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref qualityLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x002B15F4 File Offset: 0x002AF7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299176, XrefRangeEnd = 299183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x002B1644 File Offset: 0x002AF844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299183, XrefRangeEnd = 299196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref qualityLevel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x002B16C4 File Offset: 0x002AF8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299196, XrefRangeEnd = 299203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB6 RID: 43958 RVA: 0x002B1714 File Offset: 0x002AF914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGrowProgress_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref progress;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x002B1754 File Offset: 0x002AF954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299203, XrefRangeEnd = 299214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGrowProgress_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref progress;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x002B1794 File Offset: 0x002AF994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299214, XrefRangeEnd = 299222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGrowProgress_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x002B17E4 File Offset: 0x002AF9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299222, XrefRangeEnd = 299234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x002B1844 File Offset: 0x002AFA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299234, XrefRangeEnd = 299235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x002B18A4 File Offset: 0x002AFAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299235, XrefRangeEnd = 299240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x002B18F4 File Offset: 0x002AFAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299240, XrefRangeEnd = 299252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x002B1954 File Offset: 0x002AFB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299252, XrefRangeEnd = 299257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x002B19A4 File Offset: 0x002AFBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299257, XrefRangeEnd = 299269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x002B19F0 File Offset: 0x002AFBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299269, XrefRangeEnd = 299270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x002B1A3C File Offset: 0x002AFC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299270, XrefRangeEnd = 299275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendHarvestableActive_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600ABC1 RID: 43969 RVA: 0x002B1AA0 File Offset: 0x002AFCA0
		// (set) Token: 0x0600ABC2 RID: 43970 RVA: 0x002B1ADC File Offset: 0x002AFCDC
		public unsafe float SyncAccessor_<SoilLevel>k__BackingField
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 297476, RefRangeEnd = 297481, XrefRangeStart = 297476, XrefRangeEnd = 297481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 299283, RefRangeEnd = 299285, XrefRangeStart = 299275, XrefRangeEnd = 299283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600ABC3 RID: 43971 RVA: 0x002B1B28 File Offset: 0x002AFD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299285, XrefRangeEnd = 299335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_ObjectScripts_Pot(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x002B1B9C File Offset: 0x002AFD9C
		// (set) Token: 0x0600ABC5 RID: 43973 RVA: 0x002B1BD4 File Offset: 0x002AFDD4
		public unsafe string SyncAccessor_<SoilID>k__BackingField
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 187600, RefRangeEnd = 187604, XrefRangeStart = 187600, XrefRangeEnd = 187604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 299344, RefRangeEnd = 299346, XrefRangeStart = 299335, XrefRangeEnd = 299344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600ABC6 RID: 43974 RVA: 0x002B1C24 File Offset: 0x002AFE24
		// (set) Token: 0x0600ABC7 RID: 43975 RVA: 0x002B1C60 File Offset: 0x002AFE60
		public unsafe int SyncAccessor_<RemainingSoilUses>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 299354, RefRangeEnd = 299356, XrefRangeStart = 299346, XrefRangeEnd = 299354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x002B1CAC File Offset: 0x002AFEAC
		// (set) Token: 0x0600ABC9 RID: 43977 RVA: 0x002B1CE8 File Offset: 0x002AFEE8
		public unsafe float SyncAccessor_<WaterLevel>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 297515, RefRangeEnd = 297517, XrefRangeStart = 297515, XrefRangeEnd = 297517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 299364, RefRangeEnd = 299366, XrefRangeStart = 299356, XrefRangeEnd = 299364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600ABCA RID: 43978 RVA: 0x002B1D34 File Offset: 0x002AFF34
		// (set) Token: 0x0600ABCB RID: 43979 RVA: 0x002B1D74 File Offset: 0x002AFF74
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 188282, RefRangeEnd = 188290, XrefRangeStart = 188282, XrefRangeEnd = 188290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 299375, RefRangeEnd = 299377, XrefRangeStart = 299366, XrefRangeEnd = 299375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600ABCC RID: 43980 RVA: 0x002B1DC4 File Offset: 0x002AFFC4
		// (set) Token: 0x0600ABCD RID: 43981 RVA: 0x002B1E04 File Offset: 0x002B0004
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 188302, RefRangeEnd = 188309, XrefRangeStart = 188302, XrefRangeEnd = 188309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 299386, RefRangeEnd = 299388, XrefRangeStart = 299377, XrefRangeEnd = 299386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600ABCE RID: 43982 RVA: 0x002B1E54 File Offset: 0x002B0054
		// (set) Token: 0x0600ABCF RID: 43983 RVA: 0x002B1E94 File Offset: 0x002B0094
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 299397, RefRangeEnd = 299398, XrefRangeStart = 299388, XrefRangeEnd = 299397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x002B1EE4 File Offset: 0x002B00E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299398, XrefRangeEnd = 299404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x000541DA File Offset: 0x000523DA
		public Pot(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600ABD2 RID: 43986 RVA: 0x002B1F20 File Offset: 0x002B0120
		// (set) Token: 0x0600ABD3 RID: 43987 RVA: 0x000541E3 File Offset: 0x000523E3
		public unsafe static float DryThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_DryThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_DryThreshold, (void*)(&value));
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600ABD4 RID: 43988 RVA: 0x002B1F3C File Offset: 0x002B013C
		// (set) Token: 0x0600ABD5 RID: 43989 RVA: 0x000541F1 File Offset: 0x000523F1
		public unsafe static float WaterloggedThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_WaterloggedThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_WaterloggedThreshold, (void*)(&value));
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600ABD6 RID: 43990 RVA: 0x002B1F58 File Offset: 0x002B0158
		// (set) Token: 0x0600ABD7 RID: 43991 RVA: 0x000541FF File Offset: 0x000523FF
		public unsafe static float ROTATION_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_ROTATION_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_ROTATION_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600ABD8 RID: 43992 RVA: 0x002B1F74 File Offset: 0x002B0174
		// (set) Token: 0x0600ABD9 RID: 43993 RVA: 0x0005420D File Offset: 0x0005240D
		public unsafe static float MAX_CAMERA_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600ABDA RID: 43994 RVA: 0x002B1F90 File Offset: 0x002B0190
		// (set) Token: 0x0600ABDB RID: 43995 RVA: 0x0005421B File Offset: 0x0005241B
		public unsafe static float MIN_CAMERA_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600ABDC RID: 43996 RVA: 0x002B1FAC File Offset: 0x002B01AC
		// (set) Token: 0x0600ABDD RID: 43997 RVA: 0x00054229 File Offset: 0x00052429
		public unsafe Transform ModelTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ModelTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ModelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600ABDE RID: 43998 RVA: 0x002B1FDC File Offset: 0x002B01DC
		// (set) Token: 0x0600ABDF RID: 43999 RVA: 0x00054248 File Offset: 0x00052448
		public unsafe InteractableObject IntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600ABE0 RID: 44000 RVA: 0x002B200C File Offset: 0x002B020C
		// (set) Token: 0x0600ABE1 RID: 44001 RVA: 0x00054267 File Offset: 0x00052467
		public unsafe Transform PourableStartPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PourableStartPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PourableStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600ABE2 RID: 44002 RVA: 0x002B203C File Offset: 0x002B023C
		// (set) Token: 0x0600ABE3 RID: 44003 RVA: 0x00054286 File Offset: 0x00052486
		public unsafe Transform SeedStartPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedStartPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600ABE4 RID: 44004 RVA: 0x002B206C File Offset: 0x002B026C
		// (set) Token: 0x0600ABE5 RID: 44005 RVA: 0x000542A5 File Offset: 0x000524A5
		public unsafe Transform SeedRestingPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedRestingPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedRestingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600ABE6 RID: 44006 RVA: 0x002B209C File Offset: 0x002B029C
		// (set) Token: 0x0600ABE7 RID: 44007 RVA: 0x000542C4 File Offset: 0x000524C4
		public unsafe GameObject WaterLoggedVisuals
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLoggedVisuals);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLoggedVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600ABE8 RID: 44008 RVA: 0x002B20CC File Offset: 0x002B02CC
		// (set) Token: 0x0600ABE9 RID: 44009 RVA: 0x000542E3 File Offset: 0x000524E3
		public unsafe Transform LookAtPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LookAtPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LookAtPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600ABEA RID: 44010 RVA: 0x002B20FC File Offset: 0x002B02FC
		// (set) Token: 0x0600ABEB RID: 44011 RVA: 0x00054302 File Offset: 0x00052502
		public unsafe Transform AdditivesContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AdditivesContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AdditivesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600ABEC RID: 44012 RVA: 0x002B212C File Offset: 0x002B032C
		// (set) Token: 0x0600ABED RID: 44013 RVA: 0x00054321 File Offset: 0x00052521
		public unsafe Transform PlantContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PlantContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PlantContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600ABEE RID: 44014 RVA: 0x002B215C File Offset: 0x002B035C
		// (set) Token: 0x0600ABEF RID: 44015 RVA: 0x00054340 File Offset: 0x00052540
		public unsafe Transform IntObjLabel_Low
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_Low);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_Low), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600ABF0 RID: 44016 RVA: 0x002B218C File Offset: 0x002B038C
		// (set) Token: 0x0600ABF1 RID: 44017 RVA: 0x0005435F File Offset: 0x0005255F
		public unsafe Transform IntObjLabel_High
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_High);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_High), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600ABF2 RID: 44018 RVA: 0x002B21BC File Offset: 0x002B03BC
		// (set) Token: 0x0600ABF3 RID: 44019 RVA: 0x0005437E File Offset: 0x0005257E
		public unsafe Transform uiPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_uiPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600ABF4 RID: 44020 RVA: 0x002B21EC File Offset: 0x002B03EC
		// (set) Token: 0x0600ABF5 RID: 44021 RVA: 0x0005439D File Offset: 0x0005259D
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_configReplicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600ABF6 RID: 44022 RVA: 0x002B221C File Offset: 0x002B041C
		// (set) Token: 0x0600ABF7 RID: 44023 RVA: 0x000543BC File Offset: 0x000525BC
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_accessPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600ABF8 RID: 44024 RVA: 0x002B224C File Offset: 0x002B044C
		// (set) Token: 0x0600ABF9 RID: 44025 RVA: 0x000543DB File Offset: 0x000525DB
		public unsafe Transform TaskBounds
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_TaskBounds);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_TaskBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600ABFA RID: 44026 RVA: 0x002B227C File Offset: 0x002B047C
		// (set) Token: 0x0600ABFB RID: 44027 RVA: 0x000543FA File Offset: 0x000525FA
		public unsafe PotSoilCover SoilCover
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCover);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600ABFC RID: 44028 RVA: 0x002B22AC File Offset: 0x002B04AC
		// (set) Token: 0x0600ABFD RID: 44029 RVA: 0x00054419 File Offset: 0x00052619
		public unsafe Transform LeafDropPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LeafDropPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LeafDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600ABFE RID: 44030 RVA: 0x002B22DC File Offset: 0x002B04DC
		// (set) Token: 0x0600ABFF RID: 44031 RVA: 0x00054438 File Offset: 0x00052638
		public unsafe ParticleSystem PoofParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600AC00 RID: 44032 RVA: 0x002B230C File Offset: 0x002B050C
		// (set) Token: 0x0600AC01 RID: 44033 RVA: 0x00054457 File Offset: 0x00052657
		public unsafe AudioSourceController PoofSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600AC02 RID: 44034 RVA: 0x002B233C File Offset: 0x002B053C
		// (set) Token: 0x0600AC03 RID: 44035 RVA: 0x00054476 File Offset: 0x00052676
		public unsafe Transform WaterCanvasContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCanvasContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCanvasContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600AC04 RID: 44036 RVA: 0x002B236C File Offset: 0x002B056C
		// (set) Token: 0x0600AC05 RID: 44037 RVA: 0x00054495 File Offset: 0x00052695
		public unsafe Canvas WaterLevelCanvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600AC06 RID: 44038 RVA: 0x002B239C File Offset: 0x002B059C
		// (set) Token: 0x0600AC07 RID: 44039 RVA: 0x000544B4 File Offset: 0x000526B4
		public unsafe CanvasGroup WaterLevelCanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600AC08 RID: 44040 RVA: 0x002B23CC File Offset: 0x002B05CC
		// (set) Token: 0x0600AC09 RID: 44041 RVA: 0x000544D3 File Offset: 0x000526D3
		public unsafe Slider WaterLevelSlider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelSlider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600AC0A RID: 44042 RVA: 0x002B23FC File Offset: 0x002B05FC
		// (set) Token: 0x0600AC0B RID: 44043 RVA: 0x000544F2 File Offset: 0x000526F2
		public unsafe GameObject NoWaterIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_NoWaterIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_NoWaterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600AC0C RID: 44044 RVA: 0x002B242C File Offset: 0x002B062C
		// (set) Token: 0x0600AC0D RID: 44045 RVA: 0x00054511 File Offset: 0x00052711
		public unsafe PotUIElement WorldspaceUIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WorldspaceUIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotUIElement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600AC0E RID: 44046 RVA: 0x002B245C File Offset: 0x002B065C
		// (set) Token: 0x0600AC0F RID: 44047 RVA: 0x00054530 File Offset: 0x00052730
		public unsafe Sprite typeIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_typeIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600AC10 RID: 44048 RVA: 0x002B248C File Offset: 0x002B068C
		// (set) Token: 0x0600AC11 RID: 44049 RVA: 0x0005454F File Offset: 0x0005274F
		public unsafe Transform CameraContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CameraContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600AC12 RID: 44050 RVA: 0x002B24BC File Offset: 0x002B06BC
		// (set) Token: 0x0600AC13 RID: 44051 RVA: 0x0005456E File Offset: 0x0005276E
		public unsafe Transform MidshotPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MidshotPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MidshotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600AC14 RID: 44052 RVA: 0x002B24EC File Offset: 0x002B06EC
		// (set) Token: 0x0600AC15 RID: 44053 RVA: 0x0005458D File Offset: 0x0005278D
		public unsafe Transform CloseupPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CloseupPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CloseupPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600AC16 RID: 44054 RVA: 0x002B251C File Offset: 0x002B071C
		// (set) Token: 0x0600AC17 RID: 44055 RVA: 0x000545AC File Offset: 0x000527AC
		public unsafe Transform FullshotPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_FullshotPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_FullshotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600AC18 RID: 44056 RVA: 0x002B254C File Offset: 0x002B074C
		// (set) Token: 0x0600AC19 RID: 44057 RVA: 0x000545CB File Offset: 0x000527CB
		public unsafe Transform BirdsEyePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_BirdsEyePosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_BirdsEyePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600AC1A RID: 44058 RVA: 0x002B257C File Offset: 0x002B077C
		// (set) Token: 0x0600AC1B RID: 44059 RVA: 0x000545EA File Offset: 0x000527EA
		public unsafe bool AutoRotateCameraContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AutoRotateCameraContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AutoRotateCameraContainer)) = value;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600AC1C RID: 44060 RVA: 0x002B25A4 File Offset: 0x002B07A4
		// (set) Token: 0x0600AC1D RID: 44061 RVA: 0x00054605 File Offset: 0x00052805
		public unsafe Transform Dirt_Flat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Flat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Flat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600AC1E RID: 44062 RVA: 0x002B25D4 File Offset: 0x002B07D4
		// (set) Token: 0x0600AC1F RID: 44063 RVA: 0x00054624 File Offset: 0x00052824
		public unsafe Transform Dirt_Parted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Parted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Parted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600AC20 RID: 44064 RVA: 0x002B2604 File Offset: 0x002B0804
		// (set) Token: 0x0600AC21 RID: 44065 RVA: 0x00054643 File Offset: 0x00052843
		public unsafe Il2CppReferenceArray<SoilChunk> SoilChunks
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilChunks);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SoilChunk>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600AC22 RID: 44066 RVA: 0x002B2634 File Offset: 0x002B0834
		// (set) Token: 0x0600AC23 RID: 44067 RVA: 0x00054662 File Offset: 0x00052862
		public unsafe List<MeshRenderer> DirtRenderers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtRenderers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600AC24 RID: 44068 RVA: 0x002B2664 File Offset: 0x002B0864
		// (set) Token: 0x0600AC25 RID: 44069 RVA: 0x00054681 File Offset: 0x00052881
		public unsafe float PotRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PotRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PotRadius)) = value;
			}
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600AC26 RID: 44070 RVA: 0x002B268C File Offset: 0x002B088C
		// (set) Token: 0x0600AC27 RID: 44071 RVA: 0x0005469C File Offset: 0x0005289C
		public unsafe float YieldMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_YieldMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_YieldMultiplier)) = value;
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600AC28 RID: 44072 RVA: 0x002B26B4 File Offset: 0x002B08B4
		// (set) Token: 0x0600AC29 RID: 44073 RVA: 0x000546B7 File Offset: 0x000528B7
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600AC2A RID: 44074 RVA: 0x002B26DC File Offset: 0x002B08DC
		// (set) Token: 0x0600AC2B RID: 44075 RVA: 0x000546D2 File Offset: 0x000528D2
		public unsafe float MoistureDrainMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MoistureDrainMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MoistureDrainMultiplier)) = value;
			}
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0600AC2C RID: 44076 RVA: 0x002B2704 File Offset: 0x002B0904
		// (set) Token: 0x0600AC2D RID: 44077 RVA: 0x000546ED File Offset: 0x000528ED
		public unsafe bool AlignLeafDropToPlayer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer)) = value;
			}
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0600AC2E RID: 44078 RVA: 0x002B272C File Offset: 0x002B092C
		// (set) Token: 0x0600AC2F RID: 44079 RVA: 0x00054708 File Offset: 0x00052908
		public unsafe float SoilCapacity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCapacity)) = value;
			}
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600AC30 RID: 44080 RVA: 0x002B2754 File Offset: 0x002B0954
		// (set) Token: 0x0600AC31 RID: 44081 RVA: 0x00054723 File Offset: 0x00052923
		public unsafe float WaterCapacity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCapacity)) = value;
			}
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600AC32 RID: 44082 RVA: 0x002B277C File Offset: 0x002B097C
		// (set) Token: 0x0600AC33 RID: 44083 RVA: 0x0005473E File Offset: 0x0005293E
		public unsafe float WaterDrainPerHour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterDrainPerHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterDrainPerHour)) = value;
			}
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600AC34 RID: 44084 RVA: 0x002B27A4 File Offset: 0x002B09A4
		// (set) Token: 0x0600AC35 RID: 44085 RVA: 0x00054759 File Offset: 0x00052959
		public unsafe Vector3 DirtMinScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMinScale)) = value;
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600AC36 RID: 44086 RVA: 0x002B27CC File Offset: 0x002B09CC
		// (set) Token: 0x0600AC37 RID: 44087 RVA: 0x00054774 File Offset: 0x00052974
		public unsafe Vector3 DirtMaxScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMaxScale)) = value;
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600AC38 RID: 44088 RVA: 0x002B27F4 File Offset: 0x002B09F4
		// (set) Token: 0x0600AC39 RID: 44089 RVA: 0x0005478F File Offset: 0x0005298F
		public unsafe Transform Target
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Target);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600AC3A RID: 44090 RVA: 0x002B2824 File Offset: 0x002B0A24
		// (set) Token: 0x0600AC3B RID: 44091 RVA: 0x000547AE File Offset: 0x000529AE
		public unsafe UsableLightSource LightSourceOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LightSourceOverride);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UsableLightSource>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LightSourceOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600AC3C RID: 44092 RVA: 0x002B2854 File Offset: 0x002B0A54
		// (set) Token: 0x0600AC3D RID: 44093 RVA: 0x000547CD File Offset: 0x000529CD
		public unsafe float _SoilLevel_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600AC3E RID: 44094 RVA: 0x002B287C File Offset: 0x002B0A7C
		// (set) Token: 0x0600AC3F RID: 44095 RVA: 0x000547E8 File Offset: 0x000529E8
		public unsafe string _SoilID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600AC40 RID: 44096 RVA: 0x002B28A4 File Offset: 0x002B0AA4
		// (set) Token: 0x0600AC41 RID: 44097 RVA: 0x00054807 File Offset: 0x00052A07
		public unsafe int _RemainingSoilUses_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField)) = value;
			}
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600AC42 RID: 44098 RVA: 0x002B28CC File Offset: 0x002B0ACC
		// (set) Token: 0x0600AC43 RID: 44099 RVA: 0x00054822 File Offset: 0x00052A22
		public unsafe float _WaterLevel_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600AC44 RID: 44100 RVA: 0x002B28F4 File Offset: 0x002B0AF4
		// (set) Token: 0x0600AC45 RID: 44101 RVA: 0x0005483D File Offset: 0x00052A3D
		public unsafe Plant _Plant_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Plant_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Plant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600AC46 RID: 44102 RVA: 0x002B2924 File Offset: 0x002B0B24
		// (set) Token: 0x0600AC47 RID: 44103 RVA: 0x0005485C File Offset: 0x00052A5C
		public unsafe List<Additive> AppliedAdditives
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AppliedAdditives);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Additive>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AppliedAdditives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600AC48 RID: 44104 RVA: 0x002B2954 File Offset: 0x002B0B54
		// (set) Token: 0x0600AC49 RID: 44105 RVA: 0x0005487B File Offset: 0x00052A7B
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600AC4A RID: 44106 RVA: 0x002B2984 File Offset: 0x002B0B84
		// (set) Token: 0x0600AC4B RID: 44107 RVA: 0x0005489A File Offset: 0x00052A9A
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600AC4C RID: 44108 RVA: 0x002B29B4 File Offset: 0x002B0BB4
		// (set) Token: 0x0600AC4D RID: 44109 RVA: 0x000548B9 File Offset: 0x00052AB9
		public unsafe PotConfiguration _potConfiguration_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfiguration>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600AC4E RID: 44110 RVA: 0x002B29E4 File Offset: 0x002B0BE4
		// (set) Token: 0x0600AC4F RID: 44111 RVA: 0x000548D8 File Offset: 0x00052AD8
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600AC50 RID: 44112 RVA: 0x002B2A14 File Offset: 0x002B0C14
		// (set) Token: 0x0600AC51 RID: 44113 RVA: 0x000548F7 File Offset: 0x00052AF7
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600AC52 RID: 44114 RVA: 0x002B2A44 File Offset: 0x002B0C44
		// (set) Token: 0x0600AC53 RID: 44115 RVA: 0x00054916 File Offset: 0x00052B16
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__InputSlots_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600AC54 RID: 44116 RVA: 0x002B2A74 File Offset: 0x002B0C74
		// (set) Token: 0x0600AC55 RID: 44117 RVA: 0x00054935 File Offset: 0x00052B35
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600AC56 RID: 44118 RVA: 0x002B2AA4 File Offset: 0x002B0CA4
		// (set) Token: 0x0600AC57 RID: 44119 RVA: 0x00054954 File Offset: 0x00052B54
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600AC58 RID: 44120 RVA: 0x002B2ACC File Offset: 0x002B0CCC
		// (set) Token: 0x0600AC59 RID: 44121 RVA: 0x0005496F File Offset: 0x00052B6F
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x002B2AF4 File Offset: 0x002B0CF4
		// (set) Token: 0x0600AC5B RID: 44123 RVA: 0x0005498A File Offset: 0x00052B8A
		public unsafe bool intObjSetThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_intObjSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_intObjSetThisFrame)) = value;
			}
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600AC5C RID: 44124 RVA: 0x002B2B1C File Offset: 0x002B0D1C
		// (set) Token: 0x0600AC5D RID: 44125 RVA: 0x000549A5 File Offset: 0x00052BA5
		public unsafe ItemSlot outputSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_outputSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_outputSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600AC5E RID: 44126 RVA: 0x002B2B4C File Offset: 0x002B0D4C
		// (set) Token: 0x0600AC5F RID: 44127 RVA: 0x000549C4 File Offset: 0x00052BC4
		public unsafe float rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x002B2B74 File Offset: 0x002B0D74
		// (set) Token: 0x0600AC61 RID: 44129 RVA: 0x000549DF File Offset: 0x00052BDF
		public unsafe bool rotationOverridden
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotationOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotationOverridden)) = value;
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600AC62 RID: 44130 RVA: 0x002B2B9C File Offset: 0x002B0D9C
		// (set) Token: 0x0600AC63 RID: 44131 RVA: 0x000549FA File Offset: 0x00052BFA
		public unsafe SoilDefinition appliedSoilDefinition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_appliedSoilDefinition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_appliedSoilDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600AC64 RID: 44132 RVA: 0x002B2BCC File Offset: 0x002B0DCC
		// (set) Token: 0x0600AC65 RID: 44133 RVA: 0x00054A19 File Offset: 0x00052C19
		public unsafe SyncVar<float> syncVar____SoilLevel_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600AC66 RID: 44134 RVA: 0x002B2BFC File Offset: 0x002B0DFC
		// (set) Token: 0x0600AC67 RID: 44135 RVA: 0x00054A38 File Offset: 0x00052C38
		public unsafe SyncVar<string> syncVar____SoilID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600AC68 RID: 44136 RVA: 0x002B2C2C File Offset: 0x002B0E2C
		// (set) Token: 0x0600AC69 RID: 44137 RVA: 0x00054A57 File Offset: 0x00052C57
		public unsafe SyncVar<int> syncVar____RemainingSoilUses_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600AC6A RID: 44138 RVA: 0x002B2C5C File Offset: 0x002B0E5C
		// (set) Token: 0x0600AC6B RID: 44139 RVA: 0x00054A76 File Offset: 0x00052C76
		public unsafe SyncVar<float> syncVar____WaterLevel_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600AC6C RID: 44140 RVA: 0x002B2C8C File Offset: 0x002B0E8C
		// (set) Token: 0x0600AC6D RID: 44141 RVA: 0x00054A95 File Offset: 0x00052C95
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x002B2CBC File Offset: 0x002B0EBC
		// (set) Token: 0x0600AC6F RID: 44143 RVA: 0x00054AB4 File Offset: 0x00052CB4
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600AC70 RID: 44144 RVA: 0x002B2CEC File Offset: 0x002B0EEC
		// (set) Token: 0x0600AC71 RID: 44145 RVA: 0x00054AD3 File Offset: 0x00052CD3
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600AC72 RID: 44146 RVA: 0x002B2D1C File Offset: 0x002B0F1C
		// (set) Token: 0x0600AC73 RID: 44147 RVA: 0x00054AF2 File Offset: 0x00052CF2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600AC74 RID: 44148 RVA: 0x002B2D44 File Offset: 0x002B0F44
		// (set) Token: 0x0600AC75 RID: 44149 RVA: 0x00054B0D File Offset: 0x00052D0D
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040072DB RID: 29403
		private static readonly System.IntPtr NativeFieldInfoPtr_DryThreshold;

		// Token: 0x040072DC RID: 29404
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterloggedThreshold;

		// Token: 0x040072DD RID: 29405
		private static readonly System.IntPtr NativeFieldInfoPtr_ROTATION_SPEED;

		// Token: 0x040072DE RID: 29406
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CAMERA_DISTANCE;

		// Token: 0x040072DF RID: 29407
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_CAMERA_DISTANCE;

		// Token: 0x040072E0 RID: 29408
		private static readonly System.IntPtr NativeFieldInfoPtr_ModelTransform;

		// Token: 0x040072E1 RID: 29409
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040072E2 RID: 29410
		private static readonly System.IntPtr NativeFieldInfoPtr_PourableStartPoint;

		// Token: 0x040072E3 RID: 29411
		private static readonly System.IntPtr NativeFieldInfoPtr_SeedStartPoint;

		// Token: 0x040072E4 RID: 29412
		private static readonly System.IntPtr NativeFieldInfoPtr_SeedRestingPoint;

		// Token: 0x040072E5 RID: 29413
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterLoggedVisuals;

		// Token: 0x040072E6 RID: 29414
		private static readonly System.IntPtr NativeFieldInfoPtr_LookAtPoint;

		// Token: 0x040072E7 RID: 29415
		private static readonly System.IntPtr NativeFieldInfoPtr_AdditivesContainer;

		// Token: 0x040072E8 RID: 29416
		private static readonly System.IntPtr NativeFieldInfoPtr_PlantContainer;

		// Token: 0x040072E9 RID: 29417
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObjLabel_Low;

		// Token: 0x040072EA RID: 29418
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObjLabel_High;

		// Token: 0x040072EB RID: 29419
		private static readonly System.IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x040072EC RID: 29420
		private static readonly System.IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x040072ED RID: 29421
		private static readonly System.IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x040072EE RID: 29422
		private static readonly System.IntPtr NativeFieldInfoPtr_TaskBounds;

		// Token: 0x040072EF RID: 29423
		private static readonly System.IntPtr NativeFieldInfoPtr_SoilCover;

		// Token: 0x040072F0 RID: 29424
		private static readonly System.IntPtr NativeFieldInfoPtr_LeafDropPoint;

		// Token: 0x040072F1 RID: 29425
		private static readonly System.IntPtr NativeFieldInfoPtr_PoofParticles;

		// Token: 0x040072F2 RID: 29426
		private static readonly System.IntPtr NativeFieldInfoPtr_PoofSound;

		// Token: 0x040072F3 RID: 29427
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterCanvasContainer;

		// Token: 0x040072F4 RID: 29428
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterLevelCanvas;

		// Token: 0x040072F5 RID: 29429
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterLevelCanvasGroup;

		// Token: 0x040072F6 RID: 29430
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterLevelSlider;

		// Token: 0x040072F7 RID: 29431
		private static readonly System.IntPtr NativeFieldInfoPtr_NoWaterIcon;

		// Token: 0x040072F8 RID: 29432
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x040072F9 RID: 29433
		private static readonly System.IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x040072FA RID: 29434
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x040072FB RID: 29435
		private static readonly System.IntPtr NativeFieldInfoPtr_MidshotPosition;

		// Token: 0x040072FC RID: 29436
		private static readonly System.IntPtr NativeFieldInfoPtr_CloseupPosition;

		// Token: 0x040072FD RID: 29437
		private static readonly System.IntPtr NativeFieldInfoPtr_FullshotPosition;

		// Token: 0x040072FE RID: 29438
		private static readonly System.IntPtr NativeFieldInfoPtr_BirdsEyePosition;

		// Token: 0x040072FF RID: 29439
		private static readonly System.IntPtr NativeFieldInfoPtr_AutoRotateCameraContainer;

		// Token: 0x04007300 RID: 29440
		private static readonly System.IntPtr NativeFieldInfoPtr_Dirt_Flat;

		// Token: 0x04007301 RID: 29441
		private static readonly System.IntPtr NativeFieldInfoPtr_Dirt_Parted;

		// Token: 0x04007302 RID: 29442
		private static readonly System.IntPtr NativeFieldInfoPtr_SoilChunks;

		// Token: 0x04007303 RID: 29443
		private static readonly System.IntPtr NativeFieldInfoPtr_DirtRenderers;

		// Token: 0x04007304 RID: 29444
		private static readonly System.IntPtr NativeFieldInfoPtr_PotRadius;

		// Token: 0x04007305 RID: 29445
		private static readonly System.IntPtr NativeFieldInfoPtr_YieldMultiplier;

		// Token: 0x04007306 RID: 29446
		private static readonly System.IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04007307 RID: 29447
		private static readonly System.IntPtr NativeFieldInfoPtr_MoistureDrainMultiplier;

		// Token: 0x04007308 RID: 29448
		private static readonly System.IntPtr NativeFieldInfoPtr_AlignLeafDropToPlayer;

		// Token: 0x04007309 RID: 29449
		private static readonly System.IntPtr NativeFieldInfoPtr_SoilCapacity;

		// Token: 0x0400730A RID: 29450
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterCapacity;

		// Token: 0x0400730B RID: 29451
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterDrainPerHour;

		// Token: 0x0400730C RID: 29452
		private static readonly System.IntPtr NativeFieldInfoPtr_DirtMinScale;

		// Token: 0x0400730D RID: 29453
		private static readonly System.IntPtr NativeFieldInfoPtr_DirtMaxScale;

		// Token: 0x0400730E RID: 29454
		private static readonly System.IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x0400730F RID: 29455
		private static readonly System.IntPtr NativeFieldInfoPtr_LightSourceOverride;

		// Token: 0x04007310 RID: 29456
		private static readonly System.IntPtr NativeFieldInfoPtr__SoilLevel_k__BackingField;

		// Token: 0x04007311 RID: 29457
		private static readonly System.IntPtr NativeFieldInfoPtr__SoilID_k__BackingField;

		// Token: 0x04007312 RID: 29458
		private static readonly System.IntPtr NativeFieldInfoPtr__RemainingSoilUses_k__BackingField;

		// Token: 0x04007313 RID: 29459
		private static readonly System.IntPtr NativeFieldInfoPtr__WaterLevel_k__BackingField;

		// Token: 0x04007314 RID: 29460
		private static readonly System.IntPtr NativeFieldInfoPtr__Plant_k__BackingField;

		// Token: 0x04007315 RID: 29461
		private static readonly System.IntPtr NativeFieldInfoPtr_AppliedAdditives;

		// Token: 0x04007316 RID: 29462
		private static readonly System.IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x04007317 RID: 29463
		private static readonly System.IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x04007318 RID: 29464
		private static readonly System.IntPtr NativeFieldInfoPtr__potConfiguration_k__BackingField;

		// Token: 0x04007319 RID: 29465
		private static readonly System.IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x0400731A RID: 29466
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400731B RID: 29467
		private static readonly System.IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x0400731C RID: 29468
		private static readonly System.IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x0400731D RID: 29469
		private static readonly System.IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x0400731E RID: 29470
		private static readonly System.IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x0400731F RID: 29471
		private static readonly System.IntPtr NativeFieldInfoPtr_intObjSetThisFrame;

		// Token: 0x04007320 RID: 29472
		private static readonly System.IntPtr NativeFieldInfoPtr_outputSlot;

		// Token: 0x04007321 RID: 29473
		private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04007322 RID: 29474
		private static readonly System.IntPtr NativeFieldInfoPtr_rotationOverridden;

		// Token: 0x04007323 RID: 29475
		private static readonly System.IntPtr NativeFieldInfoPtr_appliedSoilDefinition;

		// Token: 0x04007324 RID: 29476
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField;

		// Token: 0x04007325 RID: 29477
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____SoilID_k__BackingField;

		// Token: 0x04007326 RID: 29478
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField;

		// Token: 0x04007327 RID: 29479
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField;

		// Token: 0x04007328 RID: 29480
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x04007329 RID: 29481
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x0400732A RID: 29482
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400732B RID: 29483
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400732C RID: 29484
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400732D RID: 29485
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0;

		// Token: 0x0400732E RID: 29486
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0;

		// Token: 0x0400732F RID: 29487
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SoilID_Public_get_String_0;

		// Token: 0x04007330 RID: 29488
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0;

		// Token: 0x04007331 RID: 29489
		private static readonly System.IntPtr NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0;

		// Token: 0x04007332 RID: 29490
		private static readonly System.IntPtr NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0;

		// Token: 0x04007333 RID: 29491
		private static readonly System.IntPtr NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0;

		// Token: 0x04007334 RID: 29492
		private static readonly System.IntPtr NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0;

		// Token: 0x04007335 RID: 29493
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0;

		// Token: 0x04007336 RID: 29494
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0;

		// Token: 0x04007337 RID: 29495
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Plant_Public_get_Plant_0;

		// Token: 0x04007338 RID: 29496
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0;

		// Token: 0x04007339 RID: 29497
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x0400733A RID: 29498
		private static readonly System.IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x0400733B RID: 29499
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x0400733C RID: 29500
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x0400733D RID: 29501
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x0400733E RID: 29502
		private static readonly System.IntPtr NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0;

		// Token: 0x0400733F RID: 29503
		private static readonly System.IntPtr NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0;

		// Token: 0x04007340 RID: 29504
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04007341 RID: 29505
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04007342 RID: 29506
		private static readonly System.IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04007343 RID: 29507
		private static readonly System.IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04007344 RID: 29508
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04007345 RID: 29509
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04007346 RID: 29510
		private static readonly System.IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007347 RID: 29511
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04007348 RID: 29512
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04007349 RID: 29513
		private static readonly System.IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400734A RID: 29514
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400734B RID: 29515
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400734C RID: 29516
		private static readonly System.IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400734D RID: 29517
		private static readonly System.IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400734E RID: 29518
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400734F RID: 29519
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04007350 RID: 29520
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04007351 RID: 29521
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04007352 RID: 29522
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007353 RID: 29523
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007354 RID: 29524
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04007355 RID: 29525
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007356 RID: 29526
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04007357 RID: 29527
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04007358 RID: 29528
		private static readonly System.IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04007359 RID: 29529
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x0400735A RID: 29530
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400735B RID: 29531
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400735C RID: 29532
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0;

		// Token: 0x0400735D RID: 29533
		private static readonly System.IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x0400735E RID: 29534
		private static readonly System.IntPtr NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0;

		// Token: 0x0400735F RID: 29535
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0;

		// Token: 0x04007360 RID: 29536
		private static readonly System.IntPtr NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0;

		// Token: 0x04007361 RID: 29537
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007362 RID: 29538
		private static readonly System.IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007363 RID: 29539
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0;

		// Token: 0x04007364 RID: 29540
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0;

		// Token: 0x04007365 RID: 29541
		private static readonly System.IntPtr NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0;

		// Token: 0x04007366 RID: 29542
		private static readonly System.IntPtr NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0;

		// Token: 0x04007367 RID: 29543
		private static readonly System.IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04007368 RID: 29544
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0;

		// Token: 0x04007369 RID: 29545
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0;

		// Token: 0x0400736A RID: 29546
		private static readonly System.IntPtr NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400736B RID: 29547
		private static readonly System.IntPtr NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0;

		// Token: 0x0400736C RID: 29548
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0;

		// Token: 0x0400736D RID: 29549
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0;

		// Token: 0x0400736E RID: 29550
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0;

		// Token: 0x0400736F RID: 29551
		private static readonly System.IntPtr NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0;

		// Token: 0x04007370 RID: 29552
		private static readonly System.IntPtr NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0;

		// Token: 0x04007371 RID: 29553
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0;

		// Token: 0x04007372 RID: 29554
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0;

		// Token: 0x04007373 RID: 29555
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0;

		// Token: 0x04007374 RID: 29556
		private static readonly System.IntPtr NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0;

		// Token: 0x04007375 RID: 29557
		private static readonly System.IntPtr NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0;

		// Token: 0x04007376 RID: 29558
		private static readonly System.IntPtr NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0;

		// Token: 0x04007377 RID: 29559
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0;

		// Token: 0x04007378 RID: 29560
		private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeTarget_Public_Void_0;

		// Token: 0x04007379 RID: 29561
		private static readonly System.IntPtr NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0;

		// Token: 0x0400737A RID: 29562
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x0400737B RID: 29563
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0;

		// Token: 0x0400737C RID: 29564
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0;

		// Token: 0x0400737D RID: 29565
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0;

		// Token: 0x0400737E RID: 29566
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0;

		// Token: 0x0400737F RID: 29567
		private static readonly System.IntPtr NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0;

		// Token: 0x04007380 RID: 29568
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04007381 RID: 29569
		private static readonly System.IntPtr NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x04007382 RID: 29570
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0;

		// Token: 0x04007383 RID: 29571
		private static readonly System.IntPtr NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0;

		// Token: 0x04007384 RID: 29572
		private static readonly System.IntPtr NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04007385 RID: 29573
		private static readonly System.IntPtr NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0;

		// Token: 0x04007386 RID: 29574
		private static readonly System.IntPtr NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0;

		// Token: 0x04007387 RID: 29575
		private static readonly System.IntPtr NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0;

		// Token: 0x04007388 RID: 29576
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04007389 RID: 29577
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400738A RID: 29578
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x0400738B RID: 29579
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0;

		// Token: 0x0400738C RID: 29580
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0;

		// Token: 0x0400738D RID: 29581
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400738E RID: 29582
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400738F RID: 29583
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007390 RID: 29584
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007391 RID: 29585
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007392 RID: 29586
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007393 RID: 29587
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007394 RID: 29588
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007395 RID: 29589
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007396 RID: 29590
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007397 RID: 29591
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007398 RID: 29592
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007399 RID: 29593
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400739A RID: 29594
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0;

		// Token: 0x0400739B RID: 29595
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x0400739C RID: 29596
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400739D RID: 29597
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0;

		// Token: 0x0400739E RID: 29598
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0;

		// Token: 0x0400739F RID: 29599
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040073A0 RID: 29600
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0;

		// Token: 0x040073A1 RID: 29601
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0;

		// Token: 0x040073A2 RID: 29602
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040073A3 RID: 29603
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0;

		// Token: 0x040073A4 RID: 29604
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0;

		// Token: 0x040073A5 RID: 29605
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040073A6 RID: 29606
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040073A7 RID: 29607
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040073A8 RID: 29608
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x040073A9 RID: 29609
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040073AA RID: 29610
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x040073AB RID: 29611
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0;

		// Token: 0x040073AC RID: 29612
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0;

		// Token: 0x040073AD RID: 29613
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040073AE RID: 29614
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0;

		// Token: 0x040073AF RID: 29615
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0;

		// Token: 0x040073B0 RID: 29616
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040073B1 RID: 29617
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x040073B2 RID: 29618
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x040073B3 RID: 29619
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0;

		// Token: 0x040073B4 RID: 29620
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x040073B5 RID: 29621
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0;

		// Token: 0x040073B6 RID: 29622
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0;

		// Token: 0x040073B7 RID: 29623
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0;

		// Token: 0x040073B8 RID: 29624
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040073B9 RID: 29625
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x040073BA RID: 29626
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x040073BB RID: 29627
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x040073BC RID: 29628
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x040073BD RID: 29629
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x040073BE RID: 29630
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0;

		// Token: 0x040073BF RID: 29631
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0;

		// Token: 0x040073C0 RID: 29632
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040073C1 RID: 29633
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0;

		// Token: 0x040073C2 RID: 29634
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x040073C3 RID: 29635
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040073C4 RID: 29636
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0;

		// Token: 0x040073C5 RID: 29637
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0;

		// Token: 0x040073C6 RID: 29638
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0;

		// Token: 0x040073C7 RID: 29639
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0;

		// Token: 0x040073C8 RID: 29640
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0;

		// Token: 0x040073C9 RID: 29641
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x040073CA RID: 29642
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040073CB RID: 29643
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040073CC RID: 29644
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040073CD RID: 29645
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040073CE RID: 29646
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040073CF RID: 29647
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040073D0 RID: 29648
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C30 RID: 3120
		[OriginalName("Assembly-CSharp.dll", "", "ECameraPosition")]
		public enum ECameraPosition
		{
			// Token: 0x040098DB RID: 39131
			Closeup,
			// Token: 0x040098DC RID: 39132
			Midshot,
			// Token: 0x040098DD RID: 39133
			Fullshot,
			// Token: 0x040098DE RID: 39134
			BirdsEye
		}

		// Token: 0x02000C31 RID: 3121
		[OriginalName("Assembly-CSharp.dll", "", "ESoilState")]
		public enum ESoilState
		{
			// Token: 0x040098E0 RID: 39136
			Flat,
			// Token: 0x040098E1 RID: 39137
			Parted,
			// Token: 0x040098E2 RID: 39138
			Packed
		}

		// Token: 0x02000C32 RID: 3122
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c")]
		[System.Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E43F RID: 58431 RVA: 0x0035F2AC File Offset: 0x0035D4AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Pot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr);
				Pot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, "<>9");
				Pot.__c.NativeFieldInfoPtr___9__194_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, "<>9__194_0");
				Pot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, 100684512);
				Pot.__c.NativeMethodInfoPtr__GetBaseData_b__194_0_Internal_String_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, 100684513);
			}

			// Token: 0x0600E440 RID: 58432 RVA: 0x0035F328 File Offset: 0x0035D528
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E441 RID: 58433 RVA: 0x0035F364 File Offset: 0x0035D564
			[CallerCount(0)]
			public unsafe string _GetBaseData_b__194_0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Pot.__c.NativeMethodInfoPtr__GetBaseData_b__194_0_Internal_String_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600E442 RID: 58434 RVA: 0x0006EFBA File Offset: 0x0006D1BA
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004673 RID: 18035
			// (get) Token: 0x0600E443 RID: 58435 RVA: 0x0035F3AC File Offset: 0x0035D5AC
			// (set) Token: 0x0600E444 RID: 58436 RVA: 0x0006EFC3 File Offset: 0x0006D1C3
			public unsafe static Pot.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004674 RID: 18036
			// (get) Token: 0x0600E445 RID: 58437 RVA: 0x0035F3D4 File Offset: 0x0035D5D4
			// (set) Token: 0x0600E446 RID: 58438 RVA: 0x0006EFD5 File Offset: 0x0006D1D5
			public unsafe static Il2CppSystem.Converter<Additive, string> __9__194_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pot.__c.NativeFieldInfoPtr___9__194_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Converter<Additive, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pot.__c.NativeFieldInfoPtr___9__194_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098E3 RID: 39139
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040098E4 RID: 39140
			private static readonly System.IntPtr NativeFieldInfoPtr___9__194_0;

			// Token: 0x040098E5 RID: 39141
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098E6 RID: 39142
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBaseData_b__194_0_Internal_String_Additive_0;
		}

		// Token: 0x02000C33 RID: 3123
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass143_0")]
		public sealed class __c__DisplayClass143_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E447 RID: 58439 RVA: 0x0035F3FC File Offset: 0x0035D5FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass143_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass143_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr);
				Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "<>4__this");
				Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "conn");
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100684514);
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100684515);
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100684516);
			}

			// Token: 0x0600E448 RID: 58440 RVA: 0x0035F48C File Offset: 0x0035D68C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass143_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E449 RID: 58441 RVA: 0x0035F4C8 File Offset: 0x0035D6C8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 297429, RefRangeEnd = 297431, XrefRangeStart = 297424, XrefRangeEnd = 297429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E44A RID: 58442 RVA: 0x0035F508 File Offset: 0x0035D708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297431, XrefRangeEnd = 297432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E44B RID: 58443 RVA: 0x0006EFE7 File Offset: 0x0006D1E7
			public __c__DisplayClass143_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004675 RID: 18037
			// (get) Token: 0x0600E44C RID: 58444 RVA: 0x0035F544 File Offset: 0x0035D744
			// (set) Token: 0x0600E44D RID: 58445 RVA: 0x0006EFF0 File Offset: 0x0006D1F0
			public unsafe Pot __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004676 RID: 18038
			// (get) Token: 0x0600E44E RID: 58446 RVA: 0x0035F574 File Offset: 0x0035D774
			// (set) Token: 0x0600E44F RID: 58447 RVA: 0x0006F00F File Offset: 0x0006D20F
			public unsafe NetworkConnection conn
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098E7 RID: 39143
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098E8 RID: 39144
			private static readonly System.IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x040098E9 RID: 39145
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098EA RID: 39146
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x040098EB RID: 39147
			private static readonly System.IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000CE3 RID: 3299
			[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass143_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EC87 RID: 60551 RVA: 0x00377384 File Offset: 0x00375584
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684517);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684518);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684519);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684520);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684521);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684522);
				}

				// Token: 0x0600EC88 RID: 60552 RVA: 0x00377464 File Offset: 0x00375664
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC89 RID: 60553 RVA: 0x003774AC File Offset: 0x003756AC
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC8A RID: 60554 RVA: 0x003774E0 File Offset: 0x003756E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297408, XrefRangeEnd = 297419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700495B RID: 18779
				// (get) Token: 0x0600EC8B RID: 60555 RVA: 0x0037751C File Offset: 0x0037571C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC8C RID: 60556 RVA: 0x0037755C File Offset: 0x0037575C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297419, XrefRangeEnd = 297424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700495C RID: 18780
				// (get) Token: 0x0600EC8D RID: 60557 RVA: 0x00377590 File Offset: 0x00375790
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC8E RID: 60558 RVA: 0x000732AD File Offset: 0x000714AD
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004958 RID: 18776
				// (get) Token: 0x0600EC8F RID: 60559 RVA: 0x003775D0 File Offset: 0x003757D0
				// (set) Token: 0x0600EC90 RID: 60560 RVA: 0x000732B6 File Offset: 0x000714B6
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004959 RID: 18777
				// (get) Token: 0x0600EC91 RID: 60561 RVA: 0x003775F8 File Offset: 0x003757F8
				// (set) Token: 0x0600EC92 RID: 60562 RVA: 0x000732D1 File Offset: 0x000714D1
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700495A RID: 18778
				// (get) Token: 0x0600EC93 RID: 60563 RVA: 0x00377628 File Offset: 0x00375828
				// (set) Token: 0x0600EC94 RID: 60564 RVA: 0x000732F0 File Offset: 0x000714F0
				public unsafe Pot.__c__DisplayClass143_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c__DisplayClass143_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009E19 RID: 40473
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009E1A RID: 40474
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009E1B RID: 40475
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009E1C RID: 40476
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009E1D RID: 40477
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E1E RID: 40478
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009E1F RID: 40479
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009E20 RID: 40480
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E21 RID: 40481
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C34 RID: 3124
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass178_0")]
		public sealed class __c__DisplayClass178_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E450 RID: 58448 RVA: 0x0035F5A4 File Offset: 0x0035D7A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass178_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass178_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr);
				Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, "additiveAssetPath");
				Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, 100684523);
				Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, 100684524);
			}

			// Token: 0x0600E451 RID: 58449 RVA: 0x0035F60C File Offset: 0x0035D80C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass178_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E452 RID: 58450 RVA: 0x0035F648 File Offset: 0x0035D848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ApplyAdditive_b__0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E453 RID: 58451 RVA: 0x0006F02E File Offset: 0x0006D22E
			public __c__DisplayClass178_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004677 RID: 18039
			// (get) Token: 0x0600E454 RID: 58452 RVA: 0x0035F698 File Offset: 0x0035D898
			// (set) Token: 0x0600E455 RID: 58453 RVA: 0x0006F037 File Offset: 0x0006D237
			public unsafe string additiveAssetPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040098EC RID: 39148
			private static readonly System.IntPtr NativeFieldInfoPtr_additiveAssetPath;

			// Token: 0x040098ED RID: 39149
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098EE RID: 39150
			private static readonly System.IntPtr NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0;
		}

		// Token: 0x02000C35 RID: 3125
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass182_0")]
		public sealed class __c__DisplayClass182_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E456 RID: 58454 RVA: 0x0035F6C0 File Offset: 0x0035D8C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass182_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr);
				Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, "additiveName");
				Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, 100684525);
				Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, 100684526);
			}

			// Token: 0x0600E457 RID: 58455 RVA: 0x0035F728 File Offset: 0x0035D928
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E458 RID: 58456 RVA: 0x0035F764 File Offset: 0x0035D964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAdditive_b__0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E459 RID: 58457 RVA: 0x0006F056 File Offset: 0x0006D256
			public __c__DisplayClass182_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004678 RID: 18040
			// (get) Token: 0x0600E45A RID: 58458 RVA: 0x0035F7B4 File Offset: 0x0035D9B4
			// (set) Token: 0x0600E45B RID: 58459 RVA: 0x0006F05F File Offset: 0x0006D25F
			public unsafe string additiveName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040098EF RID: 39151
			private static readonly System.IntPtr NativeFieldInfoPtr_additiveName;

			// Token: 0x040098F0 RID: 39152
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098F1 RID: 39153
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0;
		}

		// Token: 0x02000C36 RID: 3126
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass196_0")]
		public sealed class __c__DisplayClass196_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E45C RID: 58460 RVA: 0x0035F7DC File Offset: 0x0035D9DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass196_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass196_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr);
				Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "<>4__this");
				Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "data");
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100684527);
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100684528);
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100684529);
			}

			// Token: 0x0600E45D RID: 58461 RVA: 0x0035F86C File Offset: 0x0035DA6C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass196_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E45E RID: 58462 RVA: 0x0035F8A8 File Offset: 0x0035DAA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 297473, RefRangeEnd = 297474, XrefRangeStart = 297468, XrefRangeEnd = 297473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E45F RID: 58463 RVA: 0x0035F8E8 File Offset: 0x0035DAE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297474, XrefRangeEnd = 297476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadPlant_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E460 RID: 58464 RVA: 0x0006F07E File Offset: 0x0006D27E
			public __c__DisplayClass196_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004679 RID: 18041
			// (get) Token: 0x0600E461 RID: 58465 RVA: 0x0035F924 File Offset: 0x0035DB24
			// (set) Token: 0x0600E462 RID: 58466 RVA: 0x0006F087 File Offset: 0x0006D287
			public unsafe Pot __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700467A RID: 18042
			// (get) Token: 0x0600E463 RID: 58467 RVA: 0x0035F954 File Offset: 0x0035DB54
			// (set) Token: 0x0600E464 RID: 58468 RVA: 0x0006F0A6 File Offset: 0x0006D2A6
			public unsafe PlantData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098F2 RID: 39154
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098F3 RID: 39155
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040098F4 RID: 39156
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098F5 RID: 39157
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x040098F6 RID: 39158
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0;

			// Token: 0x02000CE4 RID: 3300
			[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass196_0+<<LoadPlant>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EC95 RID: 60565 RVA: 0x00377658 File Offset: 0x00375858
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "<<LoadPlant>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684530);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684531);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684532);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684533);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684534);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684535);
				}

				// Token: 0x0600EC96 RID: 60566 RVA: 0x00377738 File Offset: 0x00375938
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC97 RID: 60567 RVA: 0x00377780 File Offset: 0x00375980
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC98 RID: 60568 RVA: 0x003777B4 File Offset: 0x003759B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297432, XrefRangeEnd = 297463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004960 RID: 18784
				// (get) Token: 0x0600EC99 RID: 60569 RVA: 0x003777F0 File Offset: 0x003759F0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC9A RID: 60570 RVA: 0x00377830 File Offset: 0x00375A30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297463, XrefRangeEnd = 297468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004961 RID: 18785
				// (get) Token: 0x0600EC9B RID: 60571 RVA: 0x00377864 File Offset: 0x00375A64
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC9C RID: 60572 RVA: 0x0007330F File Offset: 0x0007150F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700495D RID: 18781
				// (get) Token: 0x0600EC9D RID: 60573 RVA: 0x003778A4 File Offset: 0x00375AA4
				// (set) Token: 0x0600EC9E RID: 60574 RVA: 0x00073318 File Offset: 0x00071518
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700495E RID: 18782
				// (get) Token: 0x0600EC9F RID: 60575 RVA: 0x003778CC File Offset: 0x00375ACC
				// (set) Token: 0x0600ECA0 RID: 60576 RVA: 0x00073333 File Offset: 0x00071533
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700495F RID: 18783
				// (get) Token: 0x0600ECA1 RID: 60577 RVA: 0x003778FC File Offset: 0x00375AFC
				// (set) Token: 0x0600ECA2 RID: 60578 RVA: 0x00073352 File Offset: 0x00071552
				public unsafe Pot.__c__DisplayClass196_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c__DisplayClass196_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009E22 RID: 40482
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009E23 RID: 40483
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009E24 RID: 40484
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009E25 RID: 40485
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009E26 RID: 40486
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E27 RID: 40487
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009E28 RID: 40488
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009E29 RID: 40489
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E2A RID: 40490
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
