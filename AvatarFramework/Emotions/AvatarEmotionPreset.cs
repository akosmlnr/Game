using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x0200062C RID: 1580
	[System.Serializable]
	public class AvatarEmotionPreset : Il2CppSystem.Object
	{
		// Token: 0x06008A61 RID: 35425 RVA: 0x00249728 File Offset: 0x00247928
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEmotionPreset()
		{
			Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "AvatarEmotionPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr);
			AvatarEmotionPreset.NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "PresetName");
			AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "FaceTexture");
			AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "LeftEyeRestingState");
			AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "RightEyeRestingState");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowAngleChange_L");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowAngleChange_R");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowHeightChange_L");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowHeightChange_R");
			AvatarEmotionPreset.NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, 100680661);
			AvatarEmotionPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, 100680662);
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x00249820 File Offset: 0x00247A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256191, RefRangeEnd = 256192, XrefRangeStart = 256162, XrefRangeEnd = 256191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neutralPreset);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionPreset.NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x00249898 File Offset: 0x00247A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256192, XrefRangeEnd = 256197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x00041B1A File Offset: 0x0003FD1A
		public AvatarEmotionPreset(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x06008A65 RID: 35429 RVA: 0x002498D4 File Offset: 0x00247AD4
		// (set) Token: 0x06008A66 RID: 35430 RVA: 0x00041B23 File Offset: 0x0003FD23
		public unsafe string PresetName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_PresetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_PresetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x06008A67 RID: 35431 RVA: 0x002498FC File Offset: 0x00247AFC
		// (set) Token: 0x06008A68 RID: 35432 RVA: 0x00041B42 File Offset: 0x0003FD42
		public unsafe Texture2D FaceTexture
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x06008A69 RID: 35433 RVA: 0x0024992C File Offset: 0x00247B2C
		// (set) Token: 0x06008A6A RID: 35434 RVA: 0x00041B61 File Offset: 0x0003FD61
		public unsafe Eye.EyeLidConfiguration LeftEyeRestingState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState)) = value;
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x06008A6B RID: 35435 RVA: 0x00249954 File Offset: 0x00247B54
		// (set) Token: 0x06008A6C RID: 35436 RVA: 0x00041B7C File Offset: 0x0003FD7C
		public unsafe Eye.EyeLidConfiguration RightEyeRestingState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState)) = value;
			}
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x06008A6D RID: 35437 RVA: 0x0024997C File Offset: 0x00247B7C
		// (set) Token: 0x06008A6E RID: 35438 RVA: 0x00041B97 File Offset: 0x0003FD97
		public unsafe float BrowAngleChange_L
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L)) = value;
			}
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x06008A6F RID: 35439 RVA: 0x002499A4 File Offset: 0x00247BA4
		// (set) Token: 0x06008A70 RID: 35440 RVA: 0x00041BB2 File Offset: 0x0003FDB2
		public unsafe float BrowAngleChange_R
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R)) = value;
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x06008A71 RID: 35441 RVA: 0x002499CC File Offset: 0x00247BCC
		// (set) Token: 0x06008A72 RID: 35442 RVA: 0x00041BCD File Offset: 0x0003FDCD
		public unsafe float BrowHeightChange_L
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L)) = value;
			}
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x06008A73 RID: 35443 RVA: 0x002499F4 File Offset: 0x00247BF4
		// (set) Token: 0x06008A74 RID: 35444 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		public unsafe float BrowHeightChange_R
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R)) = value;
			}
		}

		// Token: 0x04005E15 RID: 24085
		private static readonly System.IntPtr NativeFieldInfoPtr_PresetName;

		// Token: 0x04005E16 RID: 24086
		private static readonly System.IntPtr NativeFieldInfoPtr_FaceTexture;

		// Token: 0x04005E17 RID: 24087
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftEyeRestingState;

		// Token: 0x04005E18 RID: 24088
		private static readonly System.IntPtr NativeFieldInfoPtr_RightEyeRestingState;

		// Token: 0x04005E19 RID: 24089
		private static readonly System.IntPtr NativeFieldInfoPtr_BrowAngleChange_L;

		// Token: 0x04005E1A RID: 24090
		private static readonly System.IntPtr NativeFieldInfoPtr_BrowAngleChange_R;

		// Token: 0x04005E1B RID: 24091
		private static readonly System.IntPtr NativeFieldInfoPtr_BrowHeightChange_L;

		// Token: 0x04005E1C RID: 24092
		private static readonly System.IntPtr NativeFieldInfoPtr_BrowHeightChange_R;

		// Token: 0x04005E1D RID: 24093
		private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0;

		// Token: 0x04005E1E RID: 24094
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
