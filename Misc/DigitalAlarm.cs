using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000794 RID: 1940
	public class DigitalAlarm : MonoBehaviour
	{
		// Token: 0x0600B7F7 RID: 47095 RVA: 0x002DFF78 File Offset: 0x002DE178
		// Note: this type is marked as 'beforefieldinit'.
		static DigitalAlarm()
		{
			Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "DigitalAlarm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr);
			DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "FLASH_FREQUENCY");
			DigitalAlarm.NativeFieldInfoPtr_ScreenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenMesh");
			DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenMeshMaterialIndex");
			DigitalAlarm.NativeFieldInfoPtr_ScreenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenText");
			DigitalAlarm.NativeFieldInfoPtr_FlashScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "FlashScreen");
			DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "DisplayCurrentTime");
			DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenOffMat");
			DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenOnMat");
			DigitalAlarm.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100686113);
			DigitalAlarm.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100686114);
			DigitalAlarm.NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100686115);
			DigitalAlarm.NativeMethodInfoPtr_DisplayText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100686116);
			DigitalAlarm.NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100686117);
			DigitalAlarm.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100686118);
			DigitalAlarm.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100686119);
			DigitalAlarm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100686120);
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x002E00E8 File Offset: 0x002DE2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315118, XrefRangeEnd = 315150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x002E011C File Offset: 0x002DE31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315150, XrefRangeEnd = 315172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x002E0150 File Offset: 0x002DE350
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315180, RefRangeEnd = 315186, XrefRangeStart = 315172, XrefRangeEnd = 315180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScreenLit(bool lit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x002E0190 File Offset: 0x002DE390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315187, RefRangeEnd = 315189, XrefRangeStart = 315186, XrefRangeEnd = 315187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_DisplayText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x002E01D4 File Offset: 0x002DE3D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315197, RefRangeEnd = 315201, XrefRangeStart = 315189, XrefRangeEnd = 315197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayMinutes(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x002E0214 File Offset: 0x002DE414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315201, XrefRangeEnd = 315206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7FE RID: 47102 RVA: 0x002E0248 File Offset: 0x002DE448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315206, XrefRangeEnd = 315212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x002E027C File Offset: 0x002DE47C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigitalAlarm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B800 RID: 47104 RVA: 0x00059CF6 File Offset: 0x00057EF6
		public DigitalAlarm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600B801 RID: 47105 RVA: 0x002E02B8 File Offset: 0x002DE4B8
		// (set) Token: 0x0600B802 RID: 47106 RVA: 0x00059CFF File Offset: 0x00057EFF
		public unsafe static float FLASH_FREQUENCY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY, (void*)(&value));
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600B803 RID: 47107 RVA: 0x002E02D4 File Offset: 0x002DE4D4
		// (set) Token: 0x0600B804 RID: 47108 RVA: 0x00059D0D File Offset: 0x00057F0D
		public unsafe MeshRenderer ScreenMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600B805 RID: 47109 RVA: 0x002E0304 File Offset: 0x002DE504
		// (set) Token: 0x0600B806 RID: 47110 RVA: 0x00059D2C File Offset: 0x00057F2C
		public unsafe int ScreenMeshMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex)) = value;
			}
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600B807 RID: 47111 RVA: 0x002E032C File Offset: 0x002DE52C
		// (set) Token: 0x0600B808 RID: 47112 RVA: 0x00059D47 File Offset: 0x00057F47
		public unsafe TextMeshPro ScreenText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600B809 RID: 47113 RVA: 0x002E035C File Offset: 0x002DE55C
		// (set) Token: 0x0600B80A RID: 47114 RVA: 0x00059D66 File Offset: 0x00057F66
		public unsafe bool FlashScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_FlashScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_FlashScreen)) = value;
			}
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600B80B RID: 47115 RVA: 0x002E0384 File Offset: 0x002DE584
		// (set) Token: 0x0600B80C RID: 47116 RVA: 0x00059D81 File Offset: 0x00057F81
		public unsafe bool DisplayCurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime)) = value;
			}
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600B80D RID: 47117 RVA: 0x002E03AC File Offset: 0x002DE5AC
		// (set) Token: 0x0600B80E RID: 47118 RVA: 0x00059D9C File Offset: 0x00057F9C
		public unsafe Material ScreenOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600B80F RID: 47119 RVA: 0x002E03DC File Offset: 0x002DE5DC
		// (set) Token: 0x0600B810 RID: 47120 RVA: 0x00059DBB File Offset: 0x00057FBB
		public unsafe Material ScreenOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C2F RID: 31791
		private static readonly IntPtr NativeFieldInfoPtr_FLASH_FREQUENCY;

		// Token: 0x04007C30 RID: 31792
		private static readonly IntPtr NativeFieldInfoPtr_ScreenMesh;

		// Token: 0x04007C31 RID: 31793
		private static readonly IntPtr NativeFieldInfoPtr_ScreenMeshMaterialIndex;

		// Token: 0x04007C32 RID: 31794
		private static readonly IntPtr NativeFieldInfoPtr_ScreenText;

		// Token: 0x04007C33 RID: 31795
		private static readonly IntPtr NativeFieldInfoPtr_FlashScreen;

		// Token: 0x04007C34 RID: 31796
		private static readonly IntPtr NativeFieldInfoPtr_DisplayCurrentTime;

		// Token: 0x04007C35 RID: 31797
		private static readonly IntPtr NativeFieldInfoPtr_ScreenOffMat;

		// Token: 0x04007C36 RID: 31798
		private static readonly IntPtr NativeFieldInfoPtr_ScreenOnMat;

		// Token: 0x04007C37 RID: 31799
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007C38 RID: 31800
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007C39 RID: 31801
		private static readonly IntPtr NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0;

		// Token: 0x04007C3A RID: 31802
		private static readonly IntPtr NativeMethodInfoPtr_DisplayText_Public_Void_String_0;

		// Token: 0x04007C3B RID: 31803
		private static readonly IntPtr NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0;

		// Token: 0x04007C3C RID: 31804
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04007C3D RID: 31805
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04007C3E RID: 31806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
