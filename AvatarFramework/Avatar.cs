using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.AvatarFramework.Emotions;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.AvatarFramework.Impostors;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000615 RID: 1557
	public class Avatar : MonoBehaviour
	{
		// Token: 0x06008706 RID: 34566 RVA: 0x0023F5EC File Offset: 0x0023D7EC
		// Note: this type is marked as 'beforefieldinit'.
		static Avatar()
		{
			Il2CppClassPointerStore<Avatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Avatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar>.NativeClassPtr);
			Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MAX_ACCESSORIES");
			Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "USE_COMBINED_LAYERS");
			Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "DEFAULT_SMOOTHNESS");
			Avatar.NativeFieldInfoPtr_maleShoulderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "maleShoulderScale");
			Avatar.NativeFieldInfoPtr_femaleShoulderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "femaleShoulderScale");
			Avatar.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Anim");
			Avatar.NativeFieldInfoPtr_LookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LookController");
			Avatar.NativeFieldInfoPtr_BodyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BodyMeshes");
			Avatar.NativeFieldInfoPtr_ShapeKeyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "ShapeKeyMeshes");
			Avatar.NativeFieldInfoPtr_FaceMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "FaceMesh");
			Avatar.NativeFieldInfoPtr_Eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Eyes");
			Avatar.NativeFieldInfoPtr_EyeBrows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "EyeBrows");
			Avatar.NativeFieldInfoPtr_BodyContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BodyContainer");
			Avatar.NativeFieldInfoPtr_Armature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Armature");
			Avatar.NativeFieldInfoPtr_LeftShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LeftShoulder");
			Avatar.NativeFieldInfoPtr_RightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RightShoulder");
			Avatar.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "HeadBone");
			Avatar.NativeFieldInfoPtr_HipBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "HipBone");
			Avatar.NativeFieldInfoPtr_RagdollRBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RagdollRBs");
			Avatar.NativeFieldInfoPtr_RagdollColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RagdollColliders");
			Avatar.NativeFieldInfoPtr_MiddleSpineRB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MiddleSpineRB");
			Avatar.NativeFieldInfoPtr_EmotionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "EmotionManager");
			Avatar.NativeFieldInfoPtr_Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Effects");
			Avatar.NativeFieldInfoPtr_MiddleSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MiddleSpine");
			Avatar.NativeFieldInfoPtr_LowerSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LowerSpine");
			Avatar.NativeFieldInfoPtr_LowestSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LowestSpine");
			Avatar.NativeFieldInfoPtr_Impostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Impostor");
			Avatar.NativeFieldInfoPtr_FootstepSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "FootstepSounds");
			Avatar.NativeFieldInfoPtr_InitialAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "InitialAvatarSettings");
			Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "DefaultAvatarMaterial");
			Avatar.NativeFieldInfoPtr_UseImpostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "UseImpostor");
			Avatar.NativeFieldInfoPtr_onRagdollChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "onRagdollChange");
			Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<Ragdolled>k__BackingField");
			Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<CurrentEquippable>k__BackingField");
			Avatar.NativeFieldInfoPtr_appliedGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedGender");
			Avatar.NativeFieldInfoPtr_appliedWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedWeight");
			Avatar.NativeFieldInfoPtr_appliedHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedHair");
			Avatar.NativeFieldInfoPtr_appliedHairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedHairColor");
			Avatar.NativeFieldInfoPtr_appliedAccessories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedAccessories");
			Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "wearingHairBlockingAccessory");
			Avatar.NativeFieldInfoPtr_additionalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "additionalWeight");
			Avatar.NativeFieldInfoPtr_additionalGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "additionalGender");
			Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<CurrentSettings>k__BackingField");
			Avatar.NativeFieldInfoPtr_SettingsToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "SettingsToLoad");
			Avatar.NativeFieldInfoPtr_onSettingsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "onSettingsLoaded");
			Avatar.NativeFieldInfoPtr_originalHipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "originalHipPos");
			Avatar.NativeFieldInfoPtr_usingCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "usingCombinedLayer");
			Avatar.NativeFieldInfoPtr_blockEyeFaceLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "blockEyeFaceLayers");
			Avatar.NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680283);
			Avatar.NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680284);
			Avatar.NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680285);
			Avatar.NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680286);
			Avatar.NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680287);
			Avatar.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680288);
			Avatar.NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680289);
			Avatar.NativeMethodInfoPtr_LoadNaked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680290);
			Avatar.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680291);
			Avatar.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680292);
			Avatar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680293);
			Avatar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680294);
			Avatar.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680295);
			Avatar.NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680296);
			Avatar.NativeMethodInfoPtr_SetEmission_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680297);
			Avatar.NativeMethodInfoPtr_IsMale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680298);
			Avatar.NativeMethodInfoPtr_IsWhite_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680299);
			Avatar.NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680300);
			Avatar.NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680301);
			Avatar.NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680302);
			Avatar.NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680303);
			Avatar.NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680304);
			Avatar.NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680305);
			Avatar.NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680306);
			Avatar.NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680307);
			Avatar.NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680308);
			Avatar.NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680309);
			Avatar.NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680310);
			Avatar.NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680311);
			Avatar.NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680312);
			Avatar.NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680313);
			Avatar.NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680314);
			Avatar.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680315);
			Avatar.NativeMethodInfoPtr_ResetHairColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680316);
			Avatar.NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680317);
			Avatar.NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680318);
			Avatar.NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680319);
			Avatar.NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680320);
			Avatar.NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680321);
			Avatar.NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680322);
			Avatar.NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680323);
			Avatar.NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680324);
			Avatar.NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680325);
			Avatar.NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680326);
			Avatar.NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680327);
			Avatar.NativeMethodInfoPtr_DestroyAccessories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680328);
			Avatar.NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680329);
			Avatar.NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680330);
			Avatar.NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680331);
			Avatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100680332);
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x06008707 RID: 34567 RVA: 0x0023FDC4 File Offset: 0x0023DFC4
		// (set) Token: 0x06008708 RID: 34568 RVA: 0x0023FE00 File Offset: 0x0023E000
		public unsafe bool Ragdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x06008709 RID: 34569 RVA: 0x0023FE40 File Offset: 0x0023E040
		// (set) Token: 0x0600870A RID: 34570 RVA: 0x0023FE80 File Offset: 0x0023E080
		public unsafe AvatarEquippable CurrentEquippable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x0600870B RID: 34571 RVA: 0x0023FEC4 File Offset: 0x0023E0C4
		// (set) Token: 0x0600870C RID: 34572 RVA: 0x0023FF04 File Offset: 0x0023E104
		public unsafe AvatarSettings CurrentSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x0023FF48 File Offset: 0x0023E148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253047, XrefRangeEnd = 253048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x0023FF7C File Offset: 0x0023E17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253048, XrefRangeEnd = 253049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNaked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadNaked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x0600870F RID: 34575 RVA: 0x0023FFB0 File Offset: 0x0023E1B0
		public unsafe Vector3 CenterPoint
		{
			[CallerCount(81)]
			[CachedScanResults(RefRangeStart = 253051, RefRangeEnd = 253132, XrefRangeStart = 253049, XrefRangeEnd = 253051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x0023FFEC File Offset: 0x0023E1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253132, XrefRangeEnd = 253138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008711 RID: 34577 RVA: 0x00240028 File Offset: 0x0023E228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253138, XrefRangeEnd = 253143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x00240064 File Offset: 0x0023E264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253143, XrefRangeEnd = 253165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008713 RID: 34579 RVA: 0x002400A0 File Offset: 0x0023E2A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 253169, RefRangeEnd = 253175, XrefRangeStart = 253165, XrefRangeEnd = 253169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x002400E0 File Offset: 0x0023E2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253175, XrefRangeEnd = 253180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMugshot(Il2CppSystem.Action<Texture2D> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x00240124 File Offset: 0x0023E324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253180, XrefRangeEnd = 253188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmission(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetEmission_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x00240164 File Offset: 0x0023E364
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253192, RefRangeEnd = 253196, XrefRangeStart = 253188, XrefRangeEnd = 253192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_IsMale_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x002401A0 File Offset: 0x0023E3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253196, XrefRangeEnd = 253200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWhite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_IsWhite_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x002401DC File Offset: 0x0023E3DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253207, RefRangeEnd = 253208, XrefRangeStart = 253200, XrefRangeEnd = 253207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFormalAddress(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref capitalized;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x00240220 File Offset: 0x0023E420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253215, RefRangeEnd = 253216, XrefRangeStart = 253208, XrefRangeEnd = 253215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetThirdPersonAddress(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref capitalized;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x00240264 File Offset: 0x0023E464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253223, RefRangeEnd = 253224, XrefRangeStart = 253216, XrefRangeEnd = 253223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetThirdPersonPronoun(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref capitalized;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x002402A8 File Offset: 0x0023E4A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253251, RefRangeEnd = 253255, XrefRangeStart = 253224, XrefRangeEnd = 253251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShapeKeys(float gender, float weight, bool bodyOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gender;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref weight;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref bodyOnly;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x00240304 File Offset: 0x0023E504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253255, XrefRangeEnd = 253259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFeetShrunk(bool shrink, float reduction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref shrink;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref reduction;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600871D RID: 34589 RVA: 0x00240350 File Offset: 0x0023E550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253259, XrefRangeEnd = 253263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWearingHairBlockingAccessory(bool blocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref blocked;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x00240390 File Offset: 0x0023E590
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 253300, RefRangeEnd = 253313, XrefRangeStart = 253263, XrefRangeEnd = 253300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x002403D4 File Offset: 0x0023E5D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253380, RefRangeEnd = 253383, XrefRangeStart = 253313, XrefRangeEnd = 253380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNakedSettings(AvatarSettings settings, int maxLayerOrder = 19)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxLayerOrder;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x00240424 File Offset: 0x0023E624
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 253387, RefRangeEnd = 253392, XrefRangeStart = 253383, XrefRangeEnd = 253387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBodySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008721 RID: 34593 RVA: 0x00240468 File Offset: 0x0023E668
		[CallerCount(0)]
		public unsafe void SetAdditionalWeight(float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref weight;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x002404A8 File Offset: 0x0023E6A8
		[CallerCount(0)]
		public unsafe void SetAdditionalGender(float gender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gender;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x002404E8 File Offset: 0x0023E6E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253414, RefRangeEnd = 253415, XrefRangeStart = 253392, XrefRangeEnd = 253414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkinColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x00240528 File Offset: 0x0023E728
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 253441, RefRangeEnd = 253447, XrefRangeStart = 253415, XrefRangeEnd = 253441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHairSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x0024056C File Offset: 0x0023E76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 253453, RefRangeEnd = 253455, XrefRangeStart = 253447, XrefRangeEnd = 253453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHairVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x002405AC File Offset: 0x0023E7AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 253463, RefRangeEnd = 253468, XrefRangeStart = 253455, XrefRangeEnd = 253463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHairColorSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x002405F0 File Offset: 0x0023E7F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253482, RefRangeEnd = 253483, XrefRangeStart = 253468, XrefRangeEnd = 253482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideHairColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x00240630 File Offset: 0x0023E830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253497, RefRangeEnd = 253498, XrefRangeStart = 253483, XrefRangeEnd = 253497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHairColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ResetHairColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x00240664 File Offset: 0x0023E864
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253502, RefRangeEnd = 253506, XrefRangeStart = 253498, XrefRangeEnd = 253502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeBallSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x002406A8 File Offset: 0x0023E8A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253508, RefRangeEnd = 253512, XrefRangeStart = 253506, XrefRangeEnd = 253508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeLidSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x002406EC File Offset: 0x0023E8EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253520, RefRangeEnd = 253524, XrefRangeStart = 253512, XrefRangeEnd = 253520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeLidColorSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x00240730 File Offset: 0x0023E930
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253526, RefRangeEnd = 253530, XrefRangeStart = 253524, XrefRangeEnd = 253526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyebrowSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x00240774 File Offset: 0x0023E974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253535, RefRangeEnd = 253536, XrefRangeStart = 253530, XrefRangeEnd = 253535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlockEyeFaceLayers(bool block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref block;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x002407B4 File Offset: 0x0023E9B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 253631, RefRangeEnd = 253638, XrefRangeStart = 253536, XrefRangeEnd = 253631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFaceLayerSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x002407F8 File Offset: 0x0023E9F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 253666, RefRangeEnd = 253673, XrefRangeStart = 253638, XrefRangeEnd = 253666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceLayer(int index, string assetPath, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x00240858 File Offset: 0x0023EA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253673, XrefRangeEnd = 253688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceTexture(Texture2D tex, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x002408A8 File Offset: 0x0023EAA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 253771, RefRangeEnd = 253778, XrefRangeStart = 253688, XrefRangeEnd = 253771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBodyLayerSettings(AvatarSettings settings, int maxOrder = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxOrder;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x002408F8 File Offset: 0x0023EAF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 253827, RefRangeEnd = 253829, XrefRangeStart = 253778, XrefRangeEnd = 253827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBodyLayer(int index, string assetPath, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x00240958 File Offset: 0x0023EB58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253905, RefRangeEnd = 253908, XrefRangeStart = 253829, XrefRangeEnd = 253905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAccessorySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x0024099C File Offset: 0x0023EB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253908, XrefRangeEnd = 253917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAccessories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_DestroyAccessories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x002409D0 File Offset: 0x0023EBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253917, XrefRangeEnd = 253938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRagdollPhysicsEnabled(bool ragdollEnabled, bool playStandUpAnim = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ragdollEnabled;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playStandUpAnim;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x00240A28 File Offset: 0x0023EC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253938, XrefRangeEnd = 253962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AvatarEquippable SetEquippable(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x00240A84 File Offset: 0x0023EC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253962, XrefRangeEnd = 253972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveEquippableMessage(string message, Il2CppSystem.Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008738 RID: 34616 RVA: 0x00240AE4 File Offset: 0x0023ECE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253972, XrefRangeEnd = 253979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Avatar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x0003FC65 File Offset: 0x0003DE65
		public Avatar(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x00240B20 File Offset: 0x0023ED20
		// (set) Token: 0x0600873B RID: 34619 RVA: 0x0003FC6E File Offset: 0x0003DE6E
		public unsafe static int MAX_ACCESSORIES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES, (void*)(&value));
			}
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x0600873C RID: 34620 RVA: 0x00240B3C File Offset: 0x0023ED3C
		// (set) Token: 0x0600873D RID: 34621 RVA: 0x0003FC7C File Offset: 0x0003DE7C
		public unsafe static bool USE_COMBINED_LAYERS
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS, (void*)(&value));
			}
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x0600873E RID: 34622 RVA: 0x00240B58 File Offset: 0x0023ED58
		// (set) Token: 0x0600873F RID: 34623 RVA: 0x0003FC8A File Offset: 0x0003DE8A
		public unsafe static float DEFAULT_SMOOTHNESS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS, (void*)(&value));
			}
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x06008740 RID: 34624 RVA: 0x00240B74 File Offset: 0x0023ED74
		// (set) Token: 0x06008741 RID: 34625 RVA: 0x0003FC98 File Offset: 0x0003DE98
		public unsafe static float maleShoulderScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_maleShoulderScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_maleShoulderScale, (void*)(&value));
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x06008742 RID: 34626 RVA: 0x00240B90 File Offset: 0x0023ED90
		// (set) Token: 0x06008743 RID: 34627 RVA: 0x0003FCA6 File Offset: 0x0003DEA6
		public unsafe static float femaleShoulderScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_femaleShoulderScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_femaleShoulderScale, (void*)(&value));
			}
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x06008744 RID: 34628 RVA: 0x00240BAC File Offset: 0x0023EDAC
		// (set) Token: 0x06008745 RID: 34629 RVA: 0x0003FCB4 File Offset: 0x0003DEB4
		public unsafe AvatarAnimation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x06008746 RID: 34630 RVA: 0x00240BDC File Offset: 0x0023EDDC
		// (set) Token: 0x06008747 RID: 34631 RVA: 0x0003FCD3 File Offset: 0x0003DED3
		public unsafe AvatarLookController LookController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LookController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLookController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LookController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x06008748 RID: 34632 RVA: 0x00240C0C File Offset: 0x0023EE0C
		// (set) Token: 0x06008749 RID: 34633 RVA: 0x0003FCF2 File Offset: 0x0003DEF2
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> BodyMeshes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyMeshes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x0600874A RID: 34634 RVA: 0x00240C3C File Offset: 0x0023EE3C
		// (set) Token: 0x0600874B RID: 34635 RVA: 0x0003FD11 File Offset: 0x0003DF11
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> ShapeKeyMeshes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ShapeKeyMeshes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ShapeKeyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600874C RID: 34636 RVA: 0x00240C6C File Offset: 0x0023EE6C
		// (set) Token: 0x0600874D RID: 34637 RVA: 0x0003FD30 File Offset: 0x0003DF30
		public unsafe SkinnedMeshRenderer FaceMesh
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FaceMesh);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FaceMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x0600874E RID: 34638 RVA: 0x00240C9C File Offset: 0x0023EE9C
		// (set) Token: 0x0600874F RID: 34639 RVA: 0x0003FD4F File Offset: 0x0003DF4F
		public unsafe EyeController Eyes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Eyes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x06008750 RID: 34640 RVA: 0x00240CCC File Offset: 0x0023EECC
		// (set) Token: 0x06008751 RID: 34641 RVA: 0x0003FD6E File Offset: 0x0003DF6E
		public unsafe EyebrowController EyeBrows
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EyeBrows);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyebrowController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EyeBrows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x06008752 RID: 34642 RVA: 0x00240CFC File Offset: 0x0023EEFC
		// (set) Token: 0x06008753 RID: 34643 RVA: 0x0003FD8D File Offset: 0x0003DF8D
		public unsafe Transform BodyContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x06008754 RID: 34644 RVA: 0x00240D2C File Offset: 0x0023EF2C
		// (set) Token: 0x06008755 RID: 34645 RVA: 0x0003FDAC File Offset: 0x0003DFAC
		public unsafe Transform Armature
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Armature);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Armature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x06008756 RID: 34646 RVA: 0x00240D5C File Offset: 0x0023EF5C
		// (set) Token: 0x06008757 RID: 34647 RVA: 0x0003FDCB File Offset: 0x0003DFCB
		public unsafe Transform LeftShoulder
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftShoulder);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x06008758 RID: 34648 RVA: 0x00240D8C File Offset: 0x0023EF8C
		// (set) Token: 0x06008759 RID: 34649 RVA: 0x0003FDEA File Offset: 0x0003DFEA
		public unsafe Transform RightShoulder
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightShoulder);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x0600875A RID: 34650 RVA: 0x00240DBC File Offset: 0x0023EFBC
		// (set) Token: 0x0600875B RID: 34651 RVA: 0x0003FE09 File Offset: 0x0003E009
		public unsafe Transform HeadBone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HeadBone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x0600875C RID: 34652 RVA: 0x00240DEC File Offset: 0x0023EFEC
		// (set) Token: 0x0600875D RID: 34653 RVA: 0x0003FE28 File Offset: 0x0003E028
		public unsafe Transform HipBone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HipBone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HipBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x0600875E RID: 34654 RVA: 0x00240E1C File Offset: 0x0023F01C
		// (set) Token: 0x0600875F RID: 34655 RVA: 0x0003FE47 File Offset: 0x0003E047
		public unsafe Il2CppReferenceArray<Rigidbody> RagdollRBs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollRBs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollRBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x06008760 RID: 34656 RVA: 0x00240E4C File Offset: 0x0023F04C
		// (set) Token: 0x06008761 RID: 34657 RVA: 0x0003FE66 File Offset: 0x0003E066
		public unsafe Il2CppReferenceArray<Collider> RagdollColliders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollColliders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x06008762 RID: 34658 RVA: 0x00240E7C File Offset: 0x0023F07C
		// (set) Token: 0x06008763 RID: 34659 RVA: 0x0003FE85 File Offset: 0x0003E085
		public unsafe Rigidbody MiddleSpineRB
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpineRB);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpineRB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x06008764 RID: 34660 RVA: 0x00240EAC File Offset: 0x0023F0AC
		// (set) Token: 0x06008765 RID: 34661 RVA: 0x0003FEA4 File Offset: 0x0003E0A4
		public unsafe AvatarEmotionManager EmotionManager
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EmotionManager);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EmotionManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x06008766 RID: 34662 RVA: 0x00240EDC File Offset: 0x0023F0DC
		// (set) Token: 0x06008767 RID: 34663 RVA: 0x0003FEC3 File Offset: 0x0003E0C3
		public unsafe AvatarEffects Effects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Effects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Effects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x06008768 RID: 34664 RVA: 0x00240F0C File Offset: 0x0023F10C
		// (set) Token: 0x06008769 RID: 34665 RVA: 0x0003FEE2 File Offset: 0x0003E0E2
		public unsafe Transform MiddleSpine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600876A RID: 34666 RVA: 0x00240F3C File Offset: 0x0023F13C
		// (set) Token: 0x0600876B RID: 34667 RVA: 0x0003FF01 File Offset: 0x0003E101
		public unsafe Transform LowerSpine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowerSpine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowerSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x0600876C RID: 34668 RVA: 0x00240F6C File Offset: 0x0023F16C
		// (set) Token: 0x0600876D RID: 34669 RVA: 0x0003FF20 File Offset: 0x0003E120
		public unsafe Transform LowestSpine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowestSpine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowestSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x0600876E RID: 34670 RVA: 0x00240F9C File Offset: 0x0023F19C
		// (set) Token: 0x0600876F RID: 34671 RVA: 0x0003FF3F File Offset: 0x0003E13F
		public unsafe AvatarImpostor Impostor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Impostor);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarImpostor>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Impostor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x06008770 RID: 34672 RVA: 0x00240FCC File Offset: 0x0023F1CC
		// (set) Token: 0x06008771 RID: 34673 RVA: 0x0003FF5E File Offset: 0x0003E15E
		public unsafe FootstepSounds FootstepSounds
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FootstepSounds);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FootstepSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x06008772 RID: 34674 RVA: 0x00240FFC File Offset: 0x0023F1FC
		// (set) Token: 0x06008773 RID: 34675 RVA: 0x0003FF7D File Offset: 0x0003E17D
		public unsafe AvatarSettings InitialAvatarSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_InitialAvatarSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_InitialAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x06008774 RID: 34676 RVA: 0x0024102C File Offset: 0x0023F22C
		// (set) Token: 0x06008775 RID: 34677 RVA: 0x0003FF9C File Offset: 0x0003E19C
		public unsafe Material DefaultAvatarMaterial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x06008776 RID: 34678 RVA: 0x0024105C File Offset: 0x0023F25C
		// (set) Token: 0x06008777 RID: 34679 RVA: 0x0003FFBB File Offset: 0x0003E1BB
		public unsafe bool UseImpostor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_UseImpostor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_UseImpostor)) = value;
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x06008778 RID: 34680 RVA: 0x00241084 File Offset: 0x0023F284
		// (set) Token: 0x06008779 RID: 34681 RVA: 0x0003FFD6 File Offset: 0x0003E1D6
		public unsafe UnityEvent<bool, bool, bool> onRagdollChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onRagdollChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool, bool, bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onRagdollChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x0600877A RID: 34682 RVA: 0x002410B4 File Offset: 0x0023F2B4
		// (set) Token: 0x0600877B RID: 34683 RVA: 0x0003FFF5 File Offset: 0x0003E1F5
		public unsafe bool _Ragdolled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x0600877C RID: 34684 RVA: 0x002410DC File Offset: 0x0023F2DC
		// (set) Token: 0x0600877D RID: 34685 RVA: 0x00040010 File Offset: 0x0003E210
		public unsafe AvatarEquippable _CurrentEquippable_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x0600877E RID: 34686 RVA: 0x0024110C File Offset: 0x0023F30C
		// (set) Token: 0x0600877F RID: 34687 RVA: 0x0004002F File Offset: 0x0003E22F
		public unsafe float appliedGender
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedGender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedGender)) = value;
			}
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x06008780 RID: 34688 RVA: 0x00241134 File Offset: 0x0023F334
		// (set) Token: 0x06008781 RID: 34689 RVA: 0x0004004A File Offset: 0x0003E24A
		public unsafe float appliedWeight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedWeight)) = value;
			}
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x06008782 RID: 34690 RVA: 0x0024115C File Offset: 0x0023F35C
		// (set) Token: 0x06008783 RID: 34691 RVA: 0x00040065 File Offset: 0x0003E265
		public unsafe Hair appliedHair
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHair);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hair>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x06008784 RID: 34692 RVA: 0x0024118C File Offset: 0x0023F38C
		// (set) Token: 0x06008785 RID: 34693 RVA: 0x00040084 File Offset: 0x0003E284
		public unsafe Color appliedHairColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHairColor)) = value;
			}
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x06008786 RID: 34694 RVA: 0x002411B4 File Offset: 0x0023F3B4
		// (set) Token: 0x06008787 RID: 34695 RVA: 0x0004009F File Offset: 0x0003E29F
		public unsafe Il2CppReferenceArray<Accessory> appliedAccessories
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedAccessories);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Accessory>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedAccessories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x06008788 RID: 34696 RVA: 0x002411E4 File Offset: 0x0023F3E4
		// (set) Token: 0x06008789 RID: 34697 RVA: 0x000400BE File Offset: 0x0003E2BE
		public unsafe bool wearingHairBlockingAccessory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory)) = value;
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x0600878A RID: 34698 RVA: 0x0024120C File Offset: 0x0023F40C
		// (set) Token: 0x0600878B RID: 34699 RVA: 0x000400D9 File Offset: 0x0003E2D9
		public unsafe float additionalWeight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalWeight)) = value;
			}
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x0600878C RID: 34700 RVA: 0x00241234 File Offset: 0x0023F434
		// (set) Token: 0x0600878D RID: 34701 RVA: 0x000400F4 File Offset: 0x0003E2F4
		public unsafe float additionalGender
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalGender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalGender)) = value;
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x0600878E RID: 34702 RVA: 0x0024125C File Offset: 0x0023F45C
		// (set) Token: 0x0600878F RID: 34703 RVA: 0x0004010F File Offset: 0x0003E30F
		public unsafe AvatarSettings _CurrentSettings_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x06008790 RID: 34704 RVA: 0x0024128C File Offset: 0x0023F48C
		// (set) Token: 0x06008791 RID: 34705 RVA: 0x0004012E File Offset: 0x0003E32E
		public unsafe AvatarSettings SettingsToLoad
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_SettingsToLoad);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_SettingsToLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x06008792 RID: 34706 RVA: 0x002412BC File Offset: 0x0023F4BC
		// (set) Token: 0x06008793 RID: 34707 RVA: 0x0004014D File Offset: 0x0003E34D
		public unsafe UnityEvent onSettingsLoaded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onSettingsLoaded);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onSettingsLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x06008794 RID: 34708 RVA: 0x002412EC File Offset: 0x0023F4EC
		// (set) Token: 0x06008795 RID: 34709 RVA: 0x0004016C File Offset: 0x0003E36C
		public unsafe Vector3 originalHipPos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_originalHipPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_originalHipPos)) = value;
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x06008796 RID: 34710 RVA: 0x00241314 File Offset: 0x0023F514
		// (set) Token: 0x06008797 RID: 34711 RVA: 0x00040187 File Offset: 0x0003E387
		public unsafe bool usingCombinedLayer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_usingCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_usingCombinedLayer)) = value;
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x0024133C File Offset: 0x0023F53C
		// (set) Token: 0x06008799 RID: 34713 RVA: 0x000401A2 File Offset: 0x0003E3A2
		public unsafe bool blockEyeFaceLayers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_blockEyeFaceLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_blockEyeFaceLayers)) = value;
			}
		}

		// Token: 0x04005BF7 RID: 23543
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ACCESSORIES;

		// Token: 0x04005BF8 RID: 23544
		private static readonly System.IntPtr NativeFieldInfoPtr_USE_COMBINED_LAYERS;

		// Token: 0x04005BF9 RID: 23545
		private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_SMOOTHNESS;

		// Token: 0x04005BFA RID: 23546
		private static readonly System.IntPtr NativeFieldInfoPtr_maleShoulderScale;

		// Token: 0x04005BFB RID: 23547
		private static readonly System.IntPtr NativeFieldInfoPtr_femaleShoulderScale;

		// Token: 0x04005BFC RID: 23548
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005BFD RID: 23549
		private static readonly System.IntPtr NativeFieldInfoPtr_LookController;

		// Token: 0x04005BFE RID: 23550
		private static readonly System.IntPtr NativeFieldInfoPtr_BodyMeshes;

		// Token: 0x04005BFF RID: 23551
		private static readonly System.IntPtr NativeFieldInfoPtr_ShapeKeyMeshes;

		// Token: 0x04005C00 RID: 23552
		private static readonly System.IntPtr NativeFieldInfoPtr_FaceMesh;

		// Token: 0x04005C01 RID: 23553
		private static readonly System.IntPtr NativeFieldInfoPtr_Eyes;

		// Token: 0x04005C02 RID: 23554
		private static readonly System.IntPtr NativeFieldInfoPtr_EyeBrows;

		// Token: 0x04005C03 RID: 23555
		private static readonly System.IntPtr NativeFieldInfoPtr_BodyContainer;

		// Token: 0x04005C04 RID: 23556
		private static readonly System.IntPtr NativeFieldInfoPtr_Armature;

		// Token: 0x04005C05 RID: 23557
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftShoulder;

		// Token: 0x04005C06 RID: 23558
		private static readonly System.IntPtr NativeFieldInfoPtr_RightShoulder;

		// Token: 0x04005C07 RID: 23559
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005C08 RID: 23560
		private static readonly System.IntPtr NativeFieldInfoPtr_HipBone;

		// Token: 0x04005C09 RID: 23561
		private static readonly System.IntPtr NativeFieldInfoPtr_RagdollRBs;

		// Token: 0x04005C0A RID: 23562
		private static readonly System.IntPtr NativeFieldInfoPtr_RagdollColliders;

		// Token: 0x04005C0B RID: 23563
		private static readonly System.IntPtr NativeFieldInfoPtr_MiddleSpineRB;

		// Token: 0x04005C0C RID: 23564
		private static readonly System.IntPtr NativeFieldInfoPtr_EmotionManager;

		// Token: 0x04005C0D RID: 23565
		private static readonly System.IntPtr NativeFieldInfoPtr_Effects;

		// Token: 0x04005C0E RID: 23566
		private static readonly System.IntPtr NativeFieldInfoPtr_MiddleSpine;

		// Token: 0x04005C0F RID: 23567
		private static readonly System.IntPtr NativeFieldInfoPtr_LowerSpine;

		// Token: 0x04005C10 RID: 23568
		private static readonly System.IntPtr NativeFieldInfoPtr_LowestSpine;

		// Token: 0x04005C11 RID: 23569
		private static readonly System.IntPtr NativeFieldInfoPtr_Impostor;

		// Token: 0x04005C12 RID: 23570
		private static readonly System.IntPtr NativeFieldInfoPtr_FootstepSounds;

		// Token: 0x04005C13 RID: 23571
		private static readonly System.IntPtr NativeFieldInfoPtr_InitialAvatarSettings;

		// Token: 0x04005C14 RID: 23572
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultAvatarMaterial;

		// Token: 0x04005C15 RID: 23573
		private static readonly System.IntPtr NativeFieldInfoPtr_UseImpostor;

		// Token: 0x04005C16 RID: 23574
		private static readonly System.IntPtr NativeFieldInfoPtr_onRagdollChange;

		// Token: 0x04005C17 RID: 23575
		private static readonly System.IntPtr NativeFieldInfoPtr__Ragdolled_k__BackingField;

		// Token: 0x04005C18 RID: 23576
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentEquippable_k__BackingField;

		// Token: 0x04005C19 RID: 23577
		private static readonly System.IntPtr NativeFieldInfoPtr_appliedGender;

		// Token: 0x04005C1A RID: 23578
		private static readonly System.IntPtr NativeFieldInfoPtr_appliedWeight;

		// Token: 0x04005C1B RID: 23579
		private static readonly System.IntPtr NativeFieldInfoPtr_appliedHair;

		// Token: 0x04005C1C RID: 23580
		private static readonly System.IntPtr NativeFieldInfoPtr_appliedHairColor;

		// Token: 0x04005C1D RID: 23581
		private static readonly System.IntPtr NativeFieldInfoPtr_appliedAccessories;

		// Token: 0x04005C1E RID: 23582
		private static readonly System.IntPtr NativeFieldInfoPtr_wearingHairBlockingAccessory;

		// Token: 0x04005C1F RID: 23583
		private static readonly System.IntPtr NativeFieldInfoPtr_additionalWeight;

		// Token: 0x04005C20 RID: 23584
		private static readonly System.IntPtr NativeFieldInfoPtr_additionalGender;

		// Token: 0x04005C21 RID: 23585
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSettings_k__BackingField;

		// Token: 0x04005C22 RID: 23586
		private static readonly System.IntPtr NativeFieldInfoPtr_SettingsToLoad;

		// Token: 0x04005C23 RID: 23587
		private static readonly System.IntPtr NativeFieldInfoPtr_onSettingsLoaded;

		// Token: 0x04005C24 RID: 23588
		private static readonly System.IntPtr NativeFieldInfoPtr_originalHipPos;

		// Token: 0x04005C25 RID: 23589
		private static readonly System.IntPtr NativeFieldInfoPtr_usingCombinedLayer;

		// Token: 0x04005C26 RID: 23590
		private static readonly System.IntPtr NativeFieldInfoPtr_blockEyeFaceLayers;

		// Token: 0x04005C27 RID: 23591
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0;

		// Token: 0x04005C28 RID: 23592
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0;

		// Token: 0x04005C29 RID: 23593
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0;

		// Token: 0x04005C2A RID: 23594
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0;

		// Token: 0x04005C2B RID: 23595
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0;

		// Token: 0x04005C2C RID: 23596
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0;

		// Token: 0x04005C2D RID: 23597
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		// Token: 0x04005C2E RID: 23598
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadNaked_Public_Void_0;

		// Token: 0x04005C2F RID: 23599
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0;

		// Token: 0x04005C30 RID: 23600
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005C31 RID: 23601
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005C32 RID: 23602
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04005C33 RID: 23603
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04005C34 RID: 23604
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0;

		// Token: 0x04005C35 RID: 23605
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEmission_Public_Void_Color_0;

		// Token: 0x04005C36 RID: 23606
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMale_Public_Boolean_0;

		// Token: 0x04005C37 RID: 23607
		private static readonly System.IntPtr NativeMethodInfoPtr_IsWhite_Public_Boolean_0;

		// Token: 0x04005C38 RID: 23608
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0;

		// Token: 0x04005C39 RID: 23609
		private static readonly System.IntPtr NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0;

		// Token: 0x04005C3A RID: 23610
		private static readonly System.IntPtr NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0;

		// Token: 0x04005C3B RID: 23611
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0;

		// Token: 0x04005C3C RID: 23612
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0;

		// Token: 0x04005C3D RID: 23613
		private static readonly System.IntPtr NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0;

		// Token: 0x04005C3E RID: 23614
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C3F RID: 23615
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0;

		// Token: 0x04005C40 RID: 23616
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C41 RID: 23617
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0;

		// Token: 0x04005C42 RID: 23618
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0;

		// Token: 0x04005C43 RID: 23619
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0;

		// Token: 0x04005C44 RID: 23620
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C45 RID: 23621
		private static readonly System.IntPtr NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0;

		// Token: 0x04005C46 RID: 23622
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C47 RID: 23623
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0;

		// Token: 0x04005C48 RID: 23624
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetHairColor_Public_Void_0;

		// Token: 0x04005C49 RID: 23625
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C4A RID: 23626
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C4B RID: 23627
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C4C RID: 23628
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C4D RID: 23629
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0;

		// Token: 0x04005C4E RID: 23630
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C4F RID: 23631
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0;

		// Token: 0x04005C50 RID: 23632
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0;

		// Token: 0x04005C51 RID: 23633
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0;

		// Token: 0x04005C52 RID: 23634
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0;

		// Token: 0x04005C53 RID: 23635
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005C54 RID: 23636
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAccessories_Private_Void_0;

		// Token: 0x04005C55 RID: 23637
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x04005C56 RID: 23638
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0;

		// Token: 0x04005C57 RID: 23639
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04005C58 RID: 23640
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B38 RID: 2872
		[ObfuscatedName("ScheduleOne.AvatarFramework.Avatar+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA87 RID: 55943 RVA: 0x00343950 File Offset: 0x00341B50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr);
				Avatar.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9");
				Avatar.__c.NativeFieldInfoPtr___9__91_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9__91_0");
				Avatar.__c.NativeFieldInfoPtr___9__94_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9__94_0");
				Avatar.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100680335);
				Avatar.__c.NativeMethodInfoPtr__ApplyFaceLayerSettings_b__91_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100680336);
				Avatar.__c.NativeMethodInfoPtr__ApplyBodyLayerSettings_b__94_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100680337);
			}

			// Token: 0x0600DA88 RID: 55944 RVA: 0x003439F4 File Offset: 0x00341BF4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA89 RID: 55945 RVA: 0x00343A30 File Offset: 0x00341C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253041, XrefRangeEnd = 253044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ApplyFaceLayerSettings_b__91_0(Il2CppSystem.Tuple<FaceLayer, Color> x, Il2CppSystem.Tuple<FaceLayer, Color> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ApplyFaceLayerSettings_b__91_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA8A RID: 55946 RVA: 0x00343A90 File Offset: 0x00341C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253044, XrefRangeEnd = 253047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ApplyBodyLayerSettings_b__94_0(Il2CppSystem.Tuple<AvatarLayer, Color> x, Il2CppSystem.Tuple<AvatarLayer, Color> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ApplyBodyLayerSettings_b__94_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA8B RID: 55947 RVA: 0x00069FE4 File Offset: 0x000681E4
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004368 RID: 17256
			// (get) Token: 0x0600DA8C RID: 55948 RVA: 0x00343AF0 File Offset: 0x00341CF0
			// (set) Token: 0x0600DA8D RID: 55949 RVA: 0x00069FED File Offset: 0x000681ED
			public unsafe static Avatar.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004369 RID: 17257
			// (get) Token: 0x0600DA8E RID: 55950 RVA: 0x00343B18 File Offset: 0x00341D18
			// (set) Token: 0x0600DA8F RID: 55951 RVA: 0x00069FFF File Offset: 0x000681FF
			public unsafe static Il2CppSystem.Comparison<Il2CppSystem.Tuple<FaceLayer, Color>> __9__91_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9__91_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Il2CppSystem.Tuple<FaceLayer, Color>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9__91_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436A RID: 17258
			// (get) Token: 0x0600DA90 RID: 55952 RVA: 0x00343B40 File Offset: 0x00341D40
			// (set) Token: 0x0600DA91 RID: 55953 RVA: 0x0006A011 File Offset: 0x00068211
			public unsafe static Il2CppSystem.Comparison<Il2CppSystem.Tuple<AvatarLayer, Color>> __9__94_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9__94_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Il2CppSystem.Tuple<AvatarLayer, Color>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9__94_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009316 RID: 37654
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009317 RID: 37655
			private static readonly System.IntPtr NativeFieldInfoPtr___9__91_0;

			// Token: 0x04009318 RID: 37656
			private static readonly System.IntPtr NativeFieldInfoPtr___9__94_0;

			// Token: 0x04009319 RID: 37657
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400931A RID: 37658
			private static readonly System.IntPtr NativeMethodInfoPtr__ApplyFaceLayerSettings_b__91_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0;

			// Token: 0x0400931B RID: 37659
			private static readonly System.IntPtr NativeMethodInfoPtr__ApplyBodyLayerSettings_b__94_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0;
		}
	}
}
