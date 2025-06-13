using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004CB RID: 1227
	public class SlotReel : MonoBehaviour
	{
		// Token: 0x06006AB7 RID: 27319 RVA: 0x001E0D48 File Offset: 0x001DEF48
		// Note: this type is marked as 'beforefieldinit'.
		static SlotReel()
		{
			Il2CppClassPointerStore<SlotReel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "SlotReel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotReel>.NativeClassPtr);
			SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<IsSpinning>k__BackingField");
			SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<CurrentSymbol>k__BackingField");
			SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<CurrentRotation>k__BackingField");
			SlotReel.NativeFieldInfoPtr_SymbolRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SymbolRotations");
			SlotReel.NativeFieldInfoPtr_SpinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SpinSpeed");
			SlotReel.NativeFieldInfoPtr_StopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "StopSound");
			SlotReel.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "onStart");
			SlotReel.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "onStop");
			SlotReel.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676975);
			SlotReel.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676976);
			SlotReel.NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676977);
			SlotReel.NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676978);
			SlotReel.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676979);
			SlotReel.NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676980);
			SlotReel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676981);
			SlotReel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676982);
			SlotReel.NativeMethodInfoPtr_Spin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676983);
			SlotReel.NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676984);
			SlotReel.NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676985);
			SlotReel.NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676986);
			SlotReel.NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676987);
			SlotReel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676988);
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x001E0F30 File Offset: 0x001DF130
		// (set) Token: 0x06006AB9 RID: 27321 RVA: 0x001E0F6C File Offset: 0x001DF16C
		public unsafe bool IsSpinning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06006ABA RID: 27322 RVA: 0x001E0FAC File Offset: 0x001DF1AC
		// (set) Token: 0x06006ABB RID: 27323 RVA: 0x001E0FE8 File Offset: 0x001DF1E8
		public unsafe SlotMachine.ESymbol CurrentSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31397, RefRangeEnd = 31398, XrefRangeStart = 31397, XrefRangeEnd = 31398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06006ABC RID: 27324 RVA: 0x001E1028 File Offset: 0x001DF228
		// (set) Token: 0x06006ABD RID: 27325 RVA: 0x001E1064 File Offset: 0x001DF264
		public unsafe float CurrentRotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x001E10A4 File Offset: 0x001DF2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216241, XrefRangeEnd = 216245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x001E10D8 File Offset: 0x001DF2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216245, XrefRangeEnd = 216262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x001E110C File Offset: 0x001DF30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216262, XrefRangeEnd = 216263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Spin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x001E1140 File Offset: 0x001DF340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216263, XrefRangeEnd = 216264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(SlotMachine.ESymbol endSymbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endSymbol;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x001E1180 File Offset: 0x001DF380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31397, RefRangeEnd = 31398, XrefRangeStart = 31397, XrefRangeEnd = 31398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSymbol(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref symbol;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x001E11C0 File Offset: 0x001DF3C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216268, RefRangeEnd = 216270, XrefRangeStart = 216264, XrefRangeEnd = 216268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReelRotation(float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x001E1200 File Offset: 0x001DF400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216270, XrefRangeEnd = 216274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSymbolRotation(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref symbol;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x001E124C File Offset: 0x001DF44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216274, XrefRangeEnd = 216275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotReel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotReel>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x00032122 File Offset: 0x00030322
		public SlotReel(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06006AC7 RID: 27335 RVA: 0x001E1288 File Offset: 0x001DF488
		// (set) Token: 0x06006AC8 RID: 27336 RVA: 0x0003212B File Offset: 0x0003032B
		public unsafe bool _IsSpinning_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x001E12B0 File Offset: 0x001DF4B0
		// (set) Token: 0x06006ACA RID: 27338 RVA: 0x00032146 File Offset: 0x00030346
		public unsafe SlotMachine.ESymbol _CurrentSymbol_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x001E12D8 File Offset: 0x001DF4D8
		// (set) Token: 0x06006ACC RID: 27340 RVA: 0x00032161 File Offset: 0x00030361
		public unsafe float _CurrentRotation_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x001E1300 File Offset: 0x001DF500
		// (set) Token: 0x06006ACE RID: 27342 RVA: 0x0003217C File Offset: 0x0003037C
		public unsafe Il2CppReferenceArray<SlotReel.SymbolRotation> SymbolRotations
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SymbolRotations);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotReel.SymbolRotation>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SymbolRotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06006ACF RID: 27343 RVA: 0x001E1330 File Offset: 0x001DF530
		// (set) Token: 0x06006AD0 RID: 27344 RVA: 0x0003219B File Offset: 0x0003039B
		public unsafe float SpinSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SpinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SpinSpeed)) = value;
			}
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06006AD1 RID: 27345 RVA: 0x001E1358 File Offset: 0x001DF558
		// (set) Token: 0x06006AD2 RID: 27346 RVA: 0x000321B6 File Offset: 0x000303B6
		public unsafe AudioSourceController StopSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_StopSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_StopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06006AD3 RID: 27347 RVA: 0x001E1388 File Offset: 0x001DF588
		// (set) Token: 0x06006AD4 RID: 27348 RVA: 0x000321D5 File Offset: 0x000303D5
		public unsafe UnityEvent onStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x06006AD5 RID: 27349 RVA: 0x001E13B8 File Offset: 0x001DF5B8
		// (set) Token: 0x06006AD6 RID: 27350 RVA: 0x000321F4 File Offset: 0x000303F4
		public unsafe UnityEvent onStop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004929 RID: 18729
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSpinning_k__BackingField;

		// Token: 0x0400492A RID: 18730
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSymbol_k__BackingField;

		// Token: 0x0400492B RID: 18731
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentRotation_k__BackingField;

		// Token: 0x0400492C RID: 18732
		private static readonly System.IntPtr NativeFieldInfoPtr_SymbolRotations;

		// Token: 0x0400492D RID: 18733
		private static readonly System.IntPtr NativeFieldInfoPtr_SpinSpeed;

		// Token: 0x0400492E RID: 18734
		private static readonly System.IntPtr NativeFieldInfoPtr_StopSound;

		// Token: 0x0400492F RID: 18735
		private static readonly System.IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04004930 RID: 18736
		private static readonly System.IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x04004931 RID: 18737
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0;

		// Token: 0x04004932 RID: 18738
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0;

		// Token: 0x04004933 RID: 18739
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0;

		// Token: 0x04004934 RID: 18740
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0;

		// Token: 0x04004935 RID: 18741
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0;

		// Token: 0x04004936 RID: 18742
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0;

		// Token: 0x04004937 RID: 18743
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004938 RID: 18744
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004939 RID: 18745
		private static readonly System.IntPtr NativeMethodInfoPtr_Spin_Public_Void_0;

		// Token: 0x0400493A RID: 18746
		private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0;

		// Token: 0x0400493B RID: 18747
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0;

		// Token: 0x0400493C RID: 18748
		private static readonly System.IntPtr NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0;

		// Token: 0x0400493D RID: 18749
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0;

		// Token: 0x0400493E RID: 18750
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A9B RID: 2715
		[System.Serializable]
		public class SymbolRotation : Il2CppSystem.Object
		{
			// Token: 0x0600D54E RID: 54606 RVA: 0x00334F18 File Offset: 0x00333118
			// Note: this type is marked as 'beforefieldinit'.
			static SymbolRotation()
			{
				Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SymbolRotation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr);
				SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, "Symbol");
				SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, "Rotation");
				SlotReel.SymbolRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, 100676989);
			}

			// Token: 0x0600D54F RID: 54607 RVA: 0x00334F80 File Offset: 0x00333180
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SymbolRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.SymbolRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D550 RID: 54608 RVA: 0x000677B1 File Offset: 0x000659B1
			public SymbolRotation(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F1 RID: 16881
			// (get) Token: 0x0600D551 RID: 54609 RVA: 0x00334FBC File Offset: 0x003331BC
			// (set) Token: 0x0600D552 RID: 54610 RVA: 0x000677BA File Offset: 0x000659BA
			public unsafe SlotMachine.ESymbol Symbol
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol)) = value;
				}
			}

			// Token: 0x170041F2 RID: 16882
			// (get) Token: 0x0600D553 RID: 54611 RVA: 0x00334FE4 File Offset: 0x003331E4
			// (set) Token: 0x0600D554 RID: 54612 RVA: 0x000677D5 File Offset: 0x000659D5
			public unsafe float Rotation
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation)) = value;
				}
			}

			// Token: 0x04009004 RID: 36868
			private static readonly System.IntPtr NativeFieldInfoPtr_Symbol;

			// Token: 0x04009005 RID: 36869
			private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

			// Token: 0x04009006 RID: 36870
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
