using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A5 RID: 1957
	public class FoliageRustleSound : MonoBehaviour
	{
		// Token: 0x0600B93F RID: 47423 RVA: 0x002E3C2C File Offset: 0x002E1E2C
		// Note: this type is marked as 'beforefieldinit'.
		static FoliageRustleSound()
		{
			Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "FoliageRustleSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr);
			FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "ACTIVATION_RANGE_SQUARED");
			FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "COOLDOWN");
			FoliageRustleSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "Sound");
			FoliageRustleSound.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "Container");
			FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "timeOnLastHit");
			FoliageRustleSound.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100686233);
			FoliageRustleSound.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100686234);
			FoliageRustleSound.NativeMethodInfoPtr_UpdateActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100686235);
			FoliageRustleSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100686236);
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x002E3D10 File Offset: 0x002E1F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316217, XrefRangeEnd = 316223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x002E3D44 File Offset: 0x002E1F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316223, XrefRangeEnd = 316253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x002E3D88 File Offset: 0x002E1F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316253, XrefRangeEnd = 316268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_UpdateActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x002E3DBC File Offset: 0x002E1FBC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FoliageRustleSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x0005A848 File Offset: 0x00058A48
		public FoliageRustleSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x0600B945 RID: 47429 RVA: 0x002E3DF8 File Offset: 0x002E1FF8
		// (set) Token: 0x0600B946 RID: 47430 RVA: 0x0005A851 File Offset: 0x00058A51
		public unsafe static float ACTIVATION_RANGE_SQUARED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED, (void*)(&value));
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0600B947 RID: 47431 RVA: 0x002E3E14 File Offset: 0x002E2014
		// (set) Token: 0x0600B948 RID: 47432 RVA: 0x0005A85F File Offset: 0x00058A5F
		public unsafe static float COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x0600B949 RID: 47433 RVA: 0x002E3E30 File Offset: 0x002E2030
		// (set) Token: 0x0600B94A RID: 47434 RVA: 0x0005A86D File Offset: 0x00058A6D
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0600B94B RID: 47435 RVA: 0x002E3E60 File Offset: 0x002E2060
		// (set) Token: 0x0600B94C RID: 47436 RVA: 0x0005A88C File Offset: 0x00058A8C
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0600B94D RID: 47437 RVA: 0x002E3E90 File Offset: 0x002E2090
		// (set) Token: 0x0600B94E RID: 47438 RVA: 0x0005A8AB File Offset: 0x00058AAB
		public unsafe float timeOnLastHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit)) = value;
			}
		}

		// Token: 0x04007CFF RID: 31999
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED;

		// Token: 0x04007D00 RID: 32000
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN;

		// Token: 0x04007D01 RID: 32001
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x04007D02 RID: 32002
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007D03 RID: 32003
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastHit;

		// Token: 0x04007D04 RID: 32004
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007D05 RID: 32005
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04007D06 RID: 32006
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActive_Private_Void_0;

		// Token: 0x04007D07 RID: 32007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
