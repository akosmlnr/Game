using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000618 RID: 1560
	[System.Serializable]
	public class AvatarSettings : ScriptableObject
	{
		// Token: 0x06008811 RID: 34833 RVA: 0x00242AE8 File Offset: 0x00240CE8
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSettings()
		{
			Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr);
			AvatarSettings.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "SkinColor");
			AvatarSettings.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Height");
			AvatarSettings.NativeFieldInfoPtr_Gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Gender");
			AvatarSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Weight");
			AvatarSettings.NativeFieldInfoPtr_HairPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "HairPath");
			AvatarSettings.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "HairColor");
			AvatarSettings.NativeFieldInfoPtr_EyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowScale");
			AvatarSettings.NativeFieldInfoPtr_EyebrowThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowThickness");
			AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowRestingHeight");
			AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowRestingAngle");
			AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LeftEyeLidColor");
			AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "RightEyeLidColor");
			AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LeftEyeRestingState");
			AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "RightEyeRestingState");
			AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyeballMaterialIdentifier");
			AvatarSettings.NativeFieldInfoPtr_EyeBallTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyeBallTint");
			AvatarSettings.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "PupilDilation");
			AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "FaceLayerSettings");
			AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "BodyLayerSettings");
			AvatarSettings.NativeFieldInfoPtr_AccessorySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "AccessorySettings");
			AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "UseCombinedLayer");
			AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "CombinedLayerPath");
			AvatarSettings.NativeFieldInfoPtr_ImpostorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "ImpostorTexture");
			AvatarSettings.NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680387);
			AvatarSettings.NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680388);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680389);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680390);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680391);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680392);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680393);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680394);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680395);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680396);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680397);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680398);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680399);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680400);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680401);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680402);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680403);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680404);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680405);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680406);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680407);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680408);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680409);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680410);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680411);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680412);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680413);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680414);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680415);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680416);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680417);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680418);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680419);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680420);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680421);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680422);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680423);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680424);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680425);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680426);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680427);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680428);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680429);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680430);
			AvatarSettings.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680431);
			AvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680432);
			AvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680433);
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x06008812 RID: 34834 RVA: 0x00243090 File Offset: 0x00241290
		public unsafe float UpperEyelidRestingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x06008813 RID: 34835 RVA: 0x002430CC File Offset: 0x002412CC
		public unsafe float LowerEyelidRestingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x06008814 RID: 34836 RVA: 0x00243108 File Offset: 0x00241308
		public unsafe string FaceLayer1Path
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 254416, RefRangeEnd = 254418, XrefRangeStart = 254412, XrefRangeEnd = 254416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x06008815 RID: 34837 RVA: 0x00243140 File Offset: 0x00241340
		public unsafe Color FaceLayer1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254418, XrefRangeEnd = 254422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x06008816 RID: 34838 RVA: 0x0024317C File Offset: 0x0024137C
		public unsafe string FaceLayer2Path
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 254426, RefRangeEnd = 254429, XrefRangeStart = 254422, XrefRangeEnd = 254426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x06008817 RID: 34839 RVA: 0x002431B4 File Offset: 0x002413B4
		public unsafe Color FaceLayer2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254429, XrefRangeEnd = 254433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x06008818 RID: 34840 RVA: 0x002431F0 File Offset: 0x002413F0
		public unsafe string FaceLayer3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254433, XrefRangeEnd = 254437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x06008819 RID: 34841 RVA: 0x00243228 File Offset: 0x00241428
		public unsafe Color FaceLayer3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254437, XrefRangeEnd = 254441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x0600881A RID: 34842 RVA: 0x00243264 File Offset: 0x00241464
		public unsafe string FaceLayer4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254441, XrefRangeEnd = 254445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600881B RID: 34843 RVA: 0x0024329C File Offset: 0x0024149C
		public unsafe Color FaceLayer4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254445, XrefRangeEnd = 254449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x0600881C RID: 34844 RVA: 0x002432D8 File Offset: 0x002414D8
		public unsafe string FaceLayer5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254449, XrefRangeEnd = 254453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600881D RID: 34845 RVA: 0x00243310 File Offset: 0x00241510
		public unsafe Color FaceLayer5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254453, XrefRangeEnd = 254457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x0600881E RID: 34846 RVA: 0x0024334C File Offset: 0x0024154C
		public unsafe string FaceLayer6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254457, XrefRangeEnd = 254461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x0600881F RID: 34847 RVA: 0x00243384 File Offset: 0x00241584
		public unsafe Color FaceLayer6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254461, XrefRangeEnd = 254465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x06008820 RID: 34848 RVA: 0x002433C0 File Offset: 0x002415C0
		public unsafe string BodyLayer1Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254465, XrefRangeEnd = 254469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x06008821 RID: 34849 RVA: 0x002433F8 File Offset: 0x002415F8
		public unsafe Color BodyLayer1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254469, XrefRangeEnd = 254473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x06008822 RID: 34850 RVA: 0x00243434 File Offset: 0x00241634
		public unsafe string BodyLayer2Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254473, XrefRangeEnd = 254477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x06008823 RID: 34851 RVA: 0x0024346C File Offset: 0x0024166C
		public unsafe Color BodyLayer2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254477, XrefRangeEnd = 254481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x06008824 RID: 34852 RVA: 0x002434A8 File Offset: 0x002416A8
		public unsafe string BodyLayer3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254481, XrefRangeEnd = 254485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x06008825 RID: 34853 RVA: 0x002434E0 File Offset: 0x002416E0
		public unsafe Color BodyLayer3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254485, XrefRangeEnd = 254489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x06008826 RID: 34854 RVA: 0x0024351C File Offset: 0x0024171C
		public unsafe string BodyLayer4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254489, XrefRangeEnd = 254493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x06008827 RID: 34855 RVA: 0x00243554 File Offset: 0x00241754
		public unsafe Color BodyLayer4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254493, XrefRangeEnd = 254497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x06008828 RID: 34856 RVA: 0x00243590 File Offset: 0x00241790
		public unsafe string BodyLayer5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254497, XrefRangeEnd = 254501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x06008829 RID: 34857 RVA: 0x002435C8 File Offset: 0x002417C8
		public unsafe Color BodyLayer5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254501, XrefRangeEnd = 254505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600882A RID: 34858 RVA: 0x00243604 File Offset: 0x00241804
		public unsafe string BodyLayer6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254505, XrefRangeEnd = 254509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x0600882B RID: 34859 RVA: 0x0024363C File Offset: 0x0024183C
		public unsafe Color BodyLayer6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254509, XrefRangeEnd = 254513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600882C RID: 34860 RVA: 0x00243678 File Offset: 0x00241878
		public unsafe string Accessory1Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254513, XrefRangeEnd = 254517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600882D RID: 34861 RVA: 0x002436B0 File Offset: 0x002418B0
		public unsafe Color Accessory1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254517, XrefRangeEnd = 254521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x0600882E RID: 34862 RVA: 0x002436EC File Offset: 0x002418EC
		public unsafe string Accessory2Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254521, XrefRangeEnd = 254525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600882F RID: 34863 RVA: 0x00243724 File Offset: 0x00241924
		public unsafe Color Accessory2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254525, XrefRangeEnd = 254529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x00243760 File Offset: 0x00241960
		public unsafe string Accessory3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254529, XrefRangeEnd = 254533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x06008831 RID: 34865 RVA: 0x00243798 File Offset: 0x00241998
		public unsafe Color Accessory3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254533, XrefRangeEnd = 254537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x002437D4 File Offset: 0x002419D4
		public unsafe string Accessory4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254537, XrefRangeEnd = 254541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x06008833 RID: 34867 RVA: 0x0024380C File Offset: 0x00241A0C
		public unsafe Color Accessory4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254541, XrefRangeEnd = 254545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x06008834 RID: 34868 RVA: 0x00243848 File Offset: 0x00241A48
		public unsafe string Accessory5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254545, XrefRangeEnd = 254549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06008835 RID: 34869 RVA: 0x00243880 File Offset: 0x00241A80
		public unsafe Color Accessory5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254549, XrefRangeEnd = 254553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x06008836 RID: 34870 RVA: 0x002438BC File Offset: 0x00241ABC
		public unsafe string Accessory6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254553, XrefRangeEnd = 254557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x06008837 RID: 34871 RVA: 0x002438F4 File Offset: 0x00241AF4
		public unsafe Color Accessory6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254557, XrefRangeEnd = 254561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x06008838 RID: 34872 RVA: 0x00243930 File Offset: 0x00241B30
		public unsafe string Accessory7Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254561, XrefRangeEnd = 254565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x06008839 RID: 34873 RVA: 0x00243968 File Offset: 0x00241B68
		public unsafe Color Accessory7Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254565, XrefRangeEnd = 254569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600883A RID: 34874 RVA: 0x002439A4 File Offset: 0x00241BA4
		public unsafe string Accessory8Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254569, XrefRangeEnd = 254573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600883B RID: 34875 RVA: 0x002439DC File Offset: 0x00241BDC
		public unsafe Color Accessory8Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254573, XrefRangeEnd = 254577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x0600883C RID: 34876 RVA: 0x00243A18 File Offset: 0x00241C18
		public unsafe string Accessory9Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254577, XrefRangeEnd = 254581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x0600883D RID: 34877 RVA: 0x00243A50 File Offset: 0x00241C50
		public unsafe Color Accessory9Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254581, XrefRangeEnd = 254585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002939 RID: 10553
		public unsafe Il2CppSystem.Object this[string propertyName]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 254591, RefRangeEnd = 254594, XrefRangeStart = 254585, XrefRangeEnd = 254591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x00243ADC File Offset: 0x00241CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254594, XrefRangeEnd = 254595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref prettyPrint;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x00243B2C File Offset: 0x00241D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254595, XrefRangeEnd = 254615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x00040670 File Offset: 0x0003E870
		public AvatarSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x06008842 RID: 34882 RVA: 0x00243B68 File Offset: 0x00241D68
		// (set) Token: 0x06008843 RID: 34883 RVA: 0x00040679 File Offset: 0x0003E879
		public unsafe Color SkinColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x06008844 RID: 34884 RVA: 0x00243B90 File Offset: 0x00241D90
		// (set) Token: 0x06008845 RID: 34885 RVA: 0x00040694 File Offset: 0x0003E894
		public unsafe float Height
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x06008846 RID: 34886 RVA: 0x00243BB8 File Offset: 0x00241DB8
		// (set) Token: 0x06008847 RID: 34887 RVA: 0x000406AF File Offset: 0x0003E8AF
		public unsafe float Gender
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Gender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Gender)) = value;
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x06008848 RID: 34888 RVA: 0x00243BE0 File Offset: 0x00241DE0
		// (set) Token: 0x06008849 RID: 34889 RVA: 0x000406CA File Offset: 0x0003E8CA
		public unsafe float Weight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Weight)) = value;
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600884A RID: 34890 RVA: 0x00243C08 File Offset: 0x00241E08
		// (set) Token: 0x0600884B RID: 34891 RVA: 0x000406E5 File Offset: 0x0003E8E5
		public unsafe string HairPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600884C RID: 34892 RVA: 0x00243C30 File Offset: 0x00241E30
		// (set) Token: 0x0600884D RID: 34893 RVA: 0x00040704 File Offset: 0x0003E904
		public unsafe Color HairColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x0600884E RID: 34894 RVA: 0x00243C58 File Offset: 0x00241E58
		// (set) Token: 0x0600884F RID: 34895 RVA: 0x0004071F File Offset: 0x0003E91F
		public unsafe float EyebrowScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowScale)) = value;
			}
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x06008850 RID: 34896 RVA: 0x00243C80 File Offset: 0x00241E80
		// (set) Token: 0x06008851 RID: 34897 RVA: 0x0004073A File Offset: 0x0003E93A
		public unsafe float EyebrowThickness
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowThickness)) = value;
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x06008852 RID: 34898 RVA: 0x00243CA8 File Offset: 0x00241EA8
		// (set) Token: 0x06008853 RID: 34899 RVA: 0x00040755 File Offset: 0x0003E955
		public unsafe float EyebrowRestingHeight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight)) = value;
			}
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x06008854 RID: 34900 RVA: 0x00243CD0 File Offset: 0x00241ED0
		// (set) Token: 0x06008855 RID: 34901 RVA: 0x00040770 File Offset: 0x0003E970
		public unsafe float EyebrowRestingAngle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle)) = value;
			}
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x06008856 RID: 34902 RVA: 0x00243CF8 File Offset: 0x00241EF8
		// (set) Token: 0x06008857 RID: 34903 RVA: 0x0004078B File Offset: 0x0003E98B
		public unsafe Color LeftEyeLidColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor)) = value;
			}
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x06008858 RID: 34904 RVA: 0x00243D20 File Offset: 0x00241F20
		// (set) Token: 0x06008859 RID: 34905 RVA: 0x000407A6 File Offset: 0x0003E9A6
		public unsafe Color RightEyeLidColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor)) = value;
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x0600885A RID: 34906 RVA: 0x00243D48 File Offset: 0x00241F48
		// (set) Token: 0x0600885B RID: 34907 RVA: 0x000407C1 File Offset: 0x0003E9C1
		public unsafe Eye.EyeLidConfiguration LeftEyeRestingState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState)) = value;
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x0600885C RID: 34908 RVA: 0x00243D70 File Offset: 0x00241F70
		// (set) Token: 0x0600885D RID: 34909 RVA: 0x000407DC File Offset: 0x0003E9DC
		public unsafe Eye.EyeLidConfiguration RightEyeRestingState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState)) = value;
			}
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x0600885E RID: 34910 RVA: 0x00243D98 File Offset: 0x00241F98
		// (set) Token: 0x0600885F RID: 34911 RVA: 0x000407F7 File Offset: 0x0003E9F7
		public unsafe string EyeballMaterialIdentifier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x06008860 RID: 34912 RVA: 0x00243DC0 File Offset: 0x00241FC0
		// (set) Token: 0x06008861 RID: 34913 RVA: 0x00040816 File Offset: 0x0003EA16
		public unsafe Color EyeBallTint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeBallTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeBallTint)) = value;
			}
		}

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x06008862 RID: 34914 RVA: 0x00243DE8 File Offset: 0x00241FE8
		// (set) Token: 0x06008863 RID: 34915 RVA: 0x00040831 File Offset: 0x0003EA31
		public unsafe float PupilDilation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x06008864 RID: 34916 RVA: 0x00243E10 File Offset: 0x00242010
		// (set) Token: 0x06008865 RID: 34917 RVA: 0x0004084C File Offset: 0x0003EA4C
		public unsafe List<AvatarSettings.LayerSetting> FaceLayerSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x06008866 RID: 34918 RVA: 0x00243E40 File Offset: 0x00242040
		// (set) Token: 0x06008867 RID: 34919 RVA: 0x0004086B File Offset: 0x0003EA6B
		public unsafe List<AvatarSettings.LayerSetting> BodyLayerSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x06008868 RID: 34920 RVA: 0x00243E70 File Offset: 0x00242070
		// (set) Token: 0x06008869 RID: 34921 RVA: 0x0004088A File Offset: 0x0003EA8A
		public unsafe List<AvatarSettings.AccessorySetting> AccessorySettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_AccessorySettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.AccessorySetting>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_AccessorySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x0600886A RID: 34922 RVA: 0x00243EA0 File Offset: 0x002420A0
		// (set) Token: 0x0600886B RID: 34923 RVA: 0x000408A9 File Offset: 0x0003EAA9
		public unsafe bool UseCombinedLayer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer)) = value;
			}
		}

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x0600886C RID: 34924 RVA: 0x00243EC8 File Offset: 0x002420C8
		// (set) Token: 0x0600886D RID: 34925 RVA: 0x000408C4 File Offset: 0x0003EAC4
		public unsafe string CombinedLayerPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x0600886E RID: 34926 RVA: 0x00243EF0 File Offset: 0x002420F0
		// (set) Token: 0x0600886F RID: 34927 RVA: 0x000408E3 File Offset: 0x0003EAE3
		public unsafe Texture2D ImpostorTexture
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_ImpostorTexture);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_ImpostorTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005CA5 RID: 23717
		private static readonly System.IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x04005CA6 RID: 23718
		private static readonly System.IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04005CA7 RID: 23719
		private static readonly System.IntPtr NativeFieldInfoPtr_Gender;

		// Token: 0x04005CA8 RID: 23720
		private static readonly System.IntPtr NativeFieldInfoPtr_Weight;

		// Token: 0x04005CA9 RID: 23721
		private static readonly System.IntPtr NativeFieldInfoPtr_HairPath;

		// Token: 0x04005CAA RID: 23722
		private static readonly System.IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x04005CAB RID: 23723
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowScale;

		// Token: 0x04005CAC RID: 23724
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowThickness;

		// Token: 0x04005CAD RID: 23725
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowRestingHeight;

		// Token: 0x04005CAE RID: 23726
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowRestingAngle;

		// Token: 0x04005CAF RID: 23727
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftEyeLidColor;

		// Token: 0x04005CB0 RID: 23728
		private static readonly System.IntPtr NativeFieldInfoPtr_RightEyeLidColor;

		// Token: 0x04005CB1 RID: 23729
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftEyeRestingState;

		// Token: 0x04005CB2 RID: 23730
		private static readonly System.IntPtr NativeFieldInfoPtr_RightEyeRestingState;

		// Token: 0x04005CB3 RID: 23731
		private static readonly System.IntPtr NativeFieldInfoPtr_EyeballMaterialIdentifier;

		// Token: 0x04005CB4 RID: 23732
		private static readonly System.IntPtr NativeFieldInfoPtr_EyeBallTint;

		// Token: 0x04005CB5 RID: 23733
		private static readonly System.IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005CB6 RID: 23734
		private static readonly System.IntPtr NativeFieldInfoPtr_FaceLayerSettings;

		// Token: 0x04005CB7 RID: 23735
		private static readonly System.IntPtr NativeFieldInfoPtr_BodyLayerSettings;

		// Token: 0x04005CB8 RID: 23736
		private static readonly System.IntPtr NativeFieldInfoPtr_AccessorySettings;

		// Token: 0x04005CB9 RID: 23737
		private static readonly System.IntPtr NativeFieldInfoPtr_UseCombinedLayer;

		// Token: 0x04005CBA RID: 23738
		private static readonly System.IntPtr NativeFieldInfoPtr_CombinedLayerPath;

		// Token: 0x04005CBB RID: 23739
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpostorTexture;

		// Token: 0x04005CBC RID: 23740
		private static readonly System.IntPtr NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0;

		// Token: 0x04005CBD RID: 23741
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0;

		// Token: 0x04005CBE RID: 23742
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0;

		// Token: 0x04005CBF RID: 23743
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0;

		// Token: 0x04005CC0 RID: 23744
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0;

		// Token: 0x04005CC1 RID: 23745
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0;

		// Token: 0x04005CC2 RID: 23746
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0;

		// Token: 0x04005CC3 RID: 23747
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0;

		// Token: 0x04005CC4 RID: 23748
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0;

		// Token: 0x04005CC5 RID: 23749
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0;

		// Token: 0x04005CC6 RID: 23750
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0;

		// Token: 0x04005CC7 RID: 23751
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0;

		// Token: 0x04005CC8 RID: 23752
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0;

		// Token: 0x04005CC9 RID: 23753
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0;

		// Token: 0x04005CCA RID: 23754
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0;

		// Token: 0x04005CCB RID: 23755
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0;

		// Token: 0x04005CCC RID: 23756
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0;

		// Token: 0x04005CCD RID: 23757
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0;

		// Token: 0x04005CCE RID: 23758
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0;

		// Token: 0x04005CCF RID: 23759
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0;

		// Token: 0x04005CD0 RID: 23760
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0;

		// Token: 0x04005CD1 RID: 23761
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0;

		// Token: 0x04005CD2 RID: 23762
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0;

		// Token: 0x04005CD3 RID: 23763
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0;

		// Token: 0x04005CD4 RID: 23764
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0;

		// Token: 0x04005CD5 RID: 23765
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0;

		// Token: 0x04005CD6 RID: 23766
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0;

		// Token: 0x04005CD7 RID: 23767
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0;

		// Token: 0x04005CD8 RID: 23768
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0;

		// Token: 0x04005CD9 RID: 23769
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0;

		// Token: 0x04005CDA RID: 23770
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0;

		// Token: 0x04005CDB RID: 23771
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0;

		// Token: 0x04005CDC RID: 23772
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0;

		// Token: 0x04005CDD RID: 23773
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0;

		// Token: 0x04005CDE RID: 23774
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0;

		// Token: 0x04005CDF RID: 23775
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0;

		// Token: 0x04005CE0 RID: 23776
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0;

		// Token: 0x04005CE1 RID: 23777
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0;

		// Token: 0x04005CE2 RID: 23778
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0;

		// Token: 0x04005CE3 RID: 23779
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0;

		// Token: 0x04005CE4 RID: 23780
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0;

		// Token: 0x04005CE5 RID: 23781
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0;

		// Token: 0x04005CE6 RID: 23782
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0;

		// Token: 0x04005CE7 RID: 23783
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0;

		// Token: 0x04005CE8 RID: 23784
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_String_0;

		// Token: 0x04005CE9 RID: 23785
		private static readonly System.IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04005CEA RID: 23786
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B3B RID: 2875
		[System.Serializable]
		public sealed class LayerSetting : Il2CppSystem.ValueType
		{
			// Token: 0x0600DAAE RID: 55982 RVA: 0x00344110 File Offset: 0x00342310
			// Note: this type is marked as 'beforefieldinit'.
			static LayerSetting()
			{
				Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LayerSetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr);
				AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr, "layerPath");
				AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr, "layerTint");
			}

			// Token: 0x0600DAAF RID: 55983 RVA: 0x0006A0E7 File Offset: 0x000682E7
			public LayerSetting(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DAB0 RID: 55984 RVA: 0x0006A0F0 File Offset: 0x000682F0
			public LayerSetting() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr))
			{
			}

			// Token: 0x17004375 RID: 17269
			// (get) Token: 0x0600DAB1 RID: 55985 RVA: 0x00344164 File Offset: 0x00342364
			// (set) Token: 0x0600DAB2 RID: 55986 RVA: 0x0006A102 File Offset: 0x00068302
			public unsafe string layerPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004376 RID: 17270
			// (get) Token: 0x0600DAB3 RID: 55987 RVA: 0x0034418C File Offset: 0x0034238C
			// (set) Token: 0x0600DAB4 RID: 55988 RVA: 0x0006A121 File Offset: 0x00068321
			public unsafe Color layerTint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint)) = value;
				}
			}

			// Token: 0x0400932E RID: 37678
			private static readonly System.IntPtr NativeFieldInfoPtr_layerPath;

			// Token: 0x0400932F RID: 37679
			private static readonly System.IntPtr NativeFieldInfoPtr_layerTint;
		}

		// Token: 0x02000B3C RID: 2876
		[System.Serializable]
		public class AccessorySetting : Il2CppSystem.Object
		{
			// Token: 0x0600DAB5 RID: 55989 RVA: 0x003441B4 File Offset: 0x003423B4
			// Note: this type is marked as 'beforefieldinit'.
			static AccessorySetting()
			{
				Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "AccessorySetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr);
				AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, "path");
				AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, "color");
				AvatarSettings.AccessorySetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, 100680434);
			}

			// Token: 0x0600DAB6 RID: 55990 RVA: 0x0034421C File Offset: 0x0034241C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccessorySetting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.AccessorySetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DAB7 RID: 55991 RVA: 0x0006A13C File Offset: 0x0006833C
			public AccessorySetting(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004377 RID: 17271
			// (get) Token: 0x0600DAB8 RID: 55992 RVA: 0x00344258 File Offset: 0x00342458
			// (set) Token: 0x0600DAB9 RID: 55993 RVA: 0x0006A145 File Offset: 0x00068345
			public unsafe string path
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004378 RID: 17272
			// (get) Token: 0x0600DABA RID: 55994 RVA: 0x00344280 File Offset: 0x00342480
			// (set) Token: 0x0600DABB RID: 55995 RVA: 0x0006A164 File Offset: 0x00068364
			public unsafe Color color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04009330 RID: 37680
			private static readonly System.IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04009331 RID: 37681
			private static readonly System.IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04009332 RID: 37682
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
