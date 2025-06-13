using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200063B RID: 1595
	[System.Serializable]
	public class BasicAvatarSettings : ScriptableObject
	{
		// Token: 0x06008BD6 RID: 35798 RVA: 0x0024DB00 File Offset: 0x0024BD00
		// Note: this type is marked as 'beforefieldinit'.
		static BasicAvatarSettings()
		{
			Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "BasicAvatarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr);
			BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "GENDER_MULTIPLIER");
			BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "MaleUnderwearPath");
			BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FemaleUnderwearPath");
			BasicAvatarSettings.NativeFieldInfoPtr_Gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Gender");
			BasicAvatarSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Weight");
			BasicAvatarSettings.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "SkinColor");
			BasicAvatarSettings.NativeFieldInfoPtr_HairStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HairStyle");
			BasicAvatarSettings.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HairColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Mouth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Mouth");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialHair");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialDetails");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialDetailsIntensity");
			BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyeballColor");
			BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "UpperEyeLidRestingPosition");
			BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "LowerEyeLidRestingPosition");
			BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "PupilDilation");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowScale");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowThickness");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowRestingHeight");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowRestingAngle");
			BasicAvatarSettings.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Top");
			BasicAvatarSettings.NativeFieldInfoPtr_TopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "TopColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Bottom");
			BasicAvatarSettings.NativeFieldInfoPtr_BottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "BottomColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Shoes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Shoes");
			BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "ShoesColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Headwear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Headwear");
			BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HeadwearColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Eyewear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Eyewear");
			BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyewearColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Tattoos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Tattoos");
			BasicAvatarSettings.NativeMethodInfoPtr_SetValue_Public_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680800);
			BasicAvatarSettings.NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680801);
			BasicAvatarSettings.NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680802);
			BasicAvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680803);
			BasicAvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680804);
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x0024DE00 File Offset: 0x0024C000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257488, XrefRangeEnd = 257493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SetValue<T>(string fieldName, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.MethodInfoStoreGeneric_SetValue_Public_T_String_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x0024DE94 File Offset: 0x0024C094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257499, RefRangeEnd = 257500, XrefRangeStart = 257493, XrefRangeEnd = 257499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06008BD9 RID: 35801 RVA: 0x0024DEE0 File Offset: 0x0024C0E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 257602, RefRangeEnd = 257613, XrefRangeStart = 257500, XrefRangeEnd = 257602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSettings GetAvatarSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
		}

		// Token: 0x06008BDA RID: 35802 RVA: 0x0024DF20 File Offset: 0x0024C120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref prettyPrint;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicAvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x0024DF70 File Offset: 0x0024C170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257613, XrefRangeEnd = 257621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicAvatarSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x00042829 File Offset: 0x00040A29
		public BasicAvatarSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x06008BDD RID: 35805 RVA: 0x0024DFAC File Offset: 0x0024C1AC
		// (set) Token: 0x06008BDE RID: 35806 RVA: 0x00042832 File Offset: 0x00040A32
		public unsafe static float GENDER_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x06008BDF RID: 35807 RVA: 0x0024DFC8 File Offset: 0x0024C1C8
		// (set) Token: 0x06008BE0 RID: 35808 RVA: 0x00042840 File Offset: 0x00040A40
		public unsafe static string MaleUnderwearPath
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x06008BE1 RID: 35809 RVA: 0x0024DFE8 File Offset: 0x0024C1E8
		// (set) Token: 0x06008BE2 RID: 35810 RVA: 0x00042852 File Offset: 0x00040A52
		public unsafe static string FemaleUnderwearPath
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x06008BE3 RID: 35811 RVA: 0x0024E008 File Offset: 0x0024C208
		// (set) Token: 0x06008BE4 RID: 35812 RVA: 0x00042864 File Offset: 0x00040A64
		public unsafe int Gender
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Gender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Gender)) = value;
			}
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x06008BE5 RID: 35813 RVA: 0x0024E030 File Offset: 0x0024C230
		// (set) Token: 0x06008BE6 RID: 35814 RVA: 0x0004287F File Offset: 0x00040A7F
		public unsafe float Weight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Weight)) = value;
			}
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x06008BE7 RID: 35815 RVA: 0x0024E058 File Offset: 0x0024C258
		// (set) Token: 0x06008BE8 RID: 35816 RVA: 0x0004289A File Offset: 0x00040A9A
		public unsafe Color SkinColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x06008BE9 RID: 35817 RVA: 0x0024E080 File Offset: 0x0024C280
		// (set) Token: 0x06008BEA RID: 35818 RVA: 0x000428B5 File Offset: 0x00040AB5
		public unsafe string HairStyle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairStyle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairStyle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x06008BEB RID: 35819 RVA: 0x0024E0A8 File Offset: 0x0024C2A8
		// (set) Token: 0x06008BEC RID: 35820 RVA: 0x000428D4 File Offset: 0x00040AD4
		public unsafe Color HairColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x06008BED RID: 35821 RVA: 0x0024E0D0 File Offset: 0x0024C2D0
		// (set) Token: 0x06008BEE RID: 35822 RVA: 0x000428EF File Offset: 0x00040AEF
		public unsafe string Mouth
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Mouth);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Mouth), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x06008BEF RID: 35823 RVA: 0x0024E0F8 File Offset: 0x0024C2F8
		// (set) Token: 0x06008BF0 RID: 35824 RVA: 0x0004290E File Offset: 0x00040B0E
		public unsafe string FacialHair
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialHair);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialHair), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x06008BF1 RID: 35825 RVA: 0x0024E120 File Offset: 0x0024C320
		// (set) Token: 0x06008BF2 RID: 35826 RVA: 0x0004292D File Offset: 0x00040B2D
		public unsafe string FacialDetails
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x06008BF3 RID: 35827 RVA: 0x0024E148 File Offset: 0x0024C348
		// (set) Token: 0x06008BF4 RID: 35828 RVA: 0x0004294C File Offset: 0x00040B4C
		public unsafe float FacialDetailsIntensity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity)) = value;
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x06008BF5 RID: 35829 RVA: 0x0024E170 File Offset: 0x0024C370
		// (set) Token: 0x06008BF6 RID: 35830 RVA: 0x00042967 File Offset: 0x00040B67
		public unsafe Color EyeballColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor)) = value;
			}
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x06008BF7 RID: 35831 RVA: 0x0024E198 File Offset: 0x0024C398
		// (set) Token: 0x06008BF8 RID: 35832 RVA: 0x00042982 File Offset: 0x00040B82
		public unsafe float UpperEyeLidRestingPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition)) = value;
			}
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x06008BF9 RID: 35833 RVA: 0x0024E1C0 File Offset: 0x0024C3C0
		// (set) Token: 0x06008BFA RID: 35834 RVA: 0x0004299D File Offset: 0x00040B9D
		public unsafe float LowerEyeLidRestingPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition)) = value;
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x06008BFB RID: 35835 RVA: 0x0024E1E8 File Offset: 0x0024C3E8
		// (set) Token: 0x06008BFC RID: 35836 RVA: 0x000429B8 File Offset: 0x00040BB8
		public unsafe float PupilDilation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x06008BFD RID: 35837 RVA: 0x0024E210 File Offset: 0x0024C410
		// (set) Token: 0x06008BFE RID: 35838 RVA: 0x000429D3 File Offset: 0x00040BD3
		public unsafe float EyebrowScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale)) = value;
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x06008BFF RID: 35839 RVA: 0x0024E238 File Offset: 0x0024C438
		// (set) Token: 0x06008C00 RID: 35840 RVA: 0x000429EE File Offset: 0x00040BEE
		public unsafe float EyebrowThickness
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness)) = value;
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x06008C01 RID: 35841 RVA: 0x0024E260 File Offset: 0x0024C460
		// (set) Token: 0x06008C02 RID: 35842 RVA: 0x00042A09 File Offset: 0x00040C09
		public unsafe float EyebrowRestingHeight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight)) = value;
			}
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x06008C03 RID: 35843 RVA: 0x0024E288 File Offset: 0x0024C488
		// (set) Token: 0x06008C04 RID: 35844 RVA: 0x00042A24 File Offset: 0x00040C24
		public unsafe float EyebrowRestingAngle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle)) = value;
			}
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x06008C05 RID: 35845 RVA: 0x0024E2B0 File Offset: 0x0024C4B0
		// (set) Token: 0x06008C06 RID: 35846 RVA: 0x00042A3F File Offset: 0x00040C3F
		public unsafe string Top
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Top);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Top), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x06008C07 RID: 35847 RVA: 0x0024E2D8 File Offset: 0x0024C4D8
		// (set) Token: 0x06008C08 RID: 35848 RVA: 0x00042A5E File Offset: 0x00040C5E
		public unsafe Color TopColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_TopColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_TopColor)) = value;
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x06008C09 RID: 35849 RVA: 0x0024E300 File Offset: 0x0024C500
		// (set) Token: 0x06008C0A RID: 35850 RVA: 0x00042A79 File Offset: 0x00040C79
		public unsafe string Bottom
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Bottom);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Bottom), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x06008C0B RID: 35851 RVA: 0x0024E328 File Offset: 0x0024C528
		// (set) Token: 0x06008C0C RID: 35852 RVA: 0x00042A98 File Offset: 0x00040C98
		public unsafe Color BottomColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_BottomColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_BottomColor)) = value;
			}
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x06008C0D RID: 35853 RVA: 0x0024E350 File Offset: 0x0024C550
		// (set) Token: 0x06008C0E RID: 35854 RVA: 0x00042AB3 File Offset: 0x00040CB3
		public unsafe string Shoes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Shoes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Shoes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x06008C0F RID: 35855 RVA: 0x0024E378 File Offset: 0x0024C578
		// (set) Token: 0x06008C10 RID: 35856 RVA: 0x00042AD2 File Offset: 0x00040CD2
		public unsafe Color ShoesColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor)) = value;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x06008C11 RID: 35857 RVA: 0x0024E3A0 File Offset: 0x0024C5A0
		// (set) Token: 0x06008C12 RID: 35858 RVA: 0x00042AED File Offset: 0x00040CED
		public unsafe string Headwear
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Headwear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Headwear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x06008C13 RID: 35859 RVA: 0x0024E3C8 File Offset: 0x0024C5C8
		// (set) Token: 0x06008C14 RID: 35860 RVA: 0x00042B0C File Offset: 0x00040D0C
		public unsafe Color HeadwearColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor)) = value;
			}
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x06008C15 RID: 35861 RVA: 0x0024E3F0 File Offset: 0x0024C5F0
		// (set) Token: 0x06008C16 RID: 35862 RVA: 0x00042B27 File Offset: 0x00040D27
		public unsafe string Eyewear
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Eyewear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Eyewear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x06008C17 RID: 35863 RVA: 0x0024E418 File Offset: 0x0024C618
		// (set) Token: 0x06008C18 RID: 35864 RVA: 0x00042B46 File Offset: 0x00040D46
		public unsafe Color EyewearColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor)) = value;
			}
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x06008C19 RID: 35865 RVA: 0x0024E440 File Offset: 0x0024C640
		// (set) Token: 0x06008C1A RID: 35866 RVA: 0x00042B61 File Offset: 0x00040D61
		public unsafe List<string> Tattoos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Tattoos);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Tattoos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005EF8 RID: 24312
		private static readonly System.IntPtr NativeFieldInfoPtr_GENDER_MULTIPLIER;

		// Token: 0x04005EF9 RID: 24313
		private static readonly System.IntPtr NativeFieldInfoPtr_MaleUnderwearPath;

		// Token: 0x04005EFA RID: 24314
		private static readonly System.IntPtr NativeFieldInfoPtr_FemaleUnderwearPath;

		// Token: 0x04005EFB RID: 24315
		private static readonly System.IntPtr NativeFieldInfoPtr_Gender;

		// Token: 0x04005EFC RID: 24316
		private static readonly System.IntPtr NativeFieldInfoPtr_Weight;

		// Token: 0x04005EFD RID: 24317
		private static readonly System.IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x04005EFE RID: 24318
		private static readonly System.IntPtr NativeFieldInfoPtr_HairStyle;

		// Token: 0x04005EFF RID: 24319
		private static readonly System.IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x04005F00 RID: 24320
		private static readonly System.IntPtr NativeFieldInfoPtr_Mouth;

		// Token: 0x04005F01 RID: 24321
		private static readonly System.IntPtr NativeFieldInfoPtr_FacialHair;

		// Token: 0x04005F02 RID: 24322
		private static readonly System.IntPtr NativeFieldInfoPtr_FacialDetails;

		// Token: 0x04005F03 RID: 24323
		private static readonly System.IntPtr NativeFieldInfoPtr_FacialDetailsIntensity;

		// Token: 0x04005F04 RID: 24324
		private static readonly System.IntPtr NativeFieldInfoPtr_EyeballColor;

		// Token: 0x04005F05 RID: 24325
		private static readonly System.IntPtr NativeFieldInfoPtr_UpperEyeLidRestingPosition;

		// Token: 0x04005F06 RID: 24326
		private static readonly System.IntPtr NativeFieldInfoPtr_LowerEyeLidRestingPosition;

		// Token: 0x04005F07 RID: 24327
		private static readonly System.IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005F08 RID: 24328
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowScale;

		// Token: 0x04005F09 RID: 24329
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowThickness;

		// Token: 0x04005F0A RID: 24330
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowRestingHeight;

		// Token: 0x04005F0B RID: 24331
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowRestingAngle;

		// Token: 0x04005F0C RID: 24332
		private static readonly System.IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x04005F0D RID: 24333
		private static readonly System.IntPtr NativeFieldInfoPtr_TopColor;

		// Token: 0x04005F0E RID: 24334
		private static readonly System.IntPtr NativeFieldInfoPtr_Bottom;

		// Token: 0x04005F0F RID: 24335
		private static readonly System.IntPtr NativeFieldInfoPtr_BottomColor;

		// Token: 0x04005F10 RID: 24336
		private static readonly System.IntPtr NativeFieldInfoPtr_Shoes;

		// Token: 0x04005F11 RID: 24337
		private static readonly System.IntPtr NativeFieldInfoPtr_ShoesColor;

		// Token: 0x04005F12 RID: 24338
		private static readonly System.IntPtr NativeFieldInfoPtr_Headwear;

		// Token: 0x04005F13 RID: 24339
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadwearColor;

		// Token: 0x04005F14 RID: 24340
		private static readonly System.IntPtr NativeFieldInfoPtr_Eyewear;

		// Token: 0x04005F15 RID: 24341
		private static readonly System.IntPtr NativeFieldInfoPtr_EyewearColor;

		// Token: 0x04005F16 RID: 24342
		private static readonly System.IntPtr NativeFieldInfoPtr_Tattoos;

		// Token: 0x04005F17 RID: 24343
		private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_T_String_T_0;

		// Token: 0x04005F18 RID: 24344
		private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

		// Token: 0x04005F19 RID: 24345
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0;

		// Token: 0x04005F1A RID: 24346
		private static readonly System.IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04005F1B RID: 24347
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B58 RID: 2904
		private sealed class MethodInfoStoreGeneric_SetValue_Public_T_String_T_0<T>
		{
			// Token: 0x040093C6 RID: 37830
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BasicAvatarSettings.NativeMethodInfoPtr_SetValue_Public_T_String_T_0, Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B59 RID: 2905
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
		{
			// Token: 0x040093C7 RID: 37831
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BasicAvatarSettings.NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
