using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200055C RID: 1372
	[System.Serializable]
	public class FloatSmoother : Il2CppSystem.Object
	{
		// Token: 0x060078E0 RID: 30944 RVA: 0x0020F0B0 File Offset: 0x0020D2B0
		// Note: this type is marked as 'beforefieldinit'.
		static FloatSmoother()
		{
			Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "FloatSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr);
			FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			FloatSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "DefaultValue");
			FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "SmoothingSpeed");
			FloatSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "overrides");
			FloatSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678611);
			FloatSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678612);
			FloatSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678613);
			FloatSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678614);
			FloatSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678615);
			FloatSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678616);
			FloatSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678617);
			FloatSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678618);
			FloatSmoother.NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678619);
			FloatSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678620);
			FloatSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678621);
			FloatSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678622);
			FloatSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678623);
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x060078E1 RID: 30945 RVA: 0x0020F248 File Offset: 0x0020D448
		// (set) Token: 0x060078E2 RID: 30946 RVA: 0x0020F284 File Offset: 0x0020D484
		public unsafe float CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31384, RefRangeEnd = 31388, XrefRangeStart = 31384, XrefRangeEnd = 31388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x060078E3 RID: 30947 RVA: 0x0020F2C4 File Offset: 0x0020D4C4
		// (set) Token: 0x060078E4 RID: 30948 RVA: 0x0020F300 File Offset: 0x0020D500
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29248, RefRangeEnd = 29249, XrefRangeStart = 29248, XrefRangeEnd = 29249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x0020F340 File Offset: 0x0020D540
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 234865, RefRangeEnd = 234878, XrefRangeStart = 234844, XrefRangeEnd = 234865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x0020F374 File Offset: 0x0020D574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234878, XrefRangeEnd = 234896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x0020F3A8 File Offset: 0x0020D5A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 234899, RefRangeEnd = 234910, XrefRangeStart = 234896, XrefRangeEnd = 234899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x0020F3E8 File Offset: 0x0020D5E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29248, RefRangeEnd = 29249, XrefRangeStart = 29248, XrefRangeEnd = 29249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x0020F428 File Offset: 0x0020D628
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 31464, RefRangeEnd = 31475, XrefRangeStart = 31464, XrefRangeEnd = 31475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSmoothingSpeed(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x0020F468 File Offset: 0x0020D668
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 234954, RefRangeEnd = 234984, XrefRangeStart = 234910, XrefRangeEnd = 234954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(float value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x0020F4C8 File Offset: 0x0020D6C8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 235020, RefRangeEnd = 235048, XrefRangeStart = 234984, XrefRangeEnd = 235020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x0020F50C File Offset: 0x0020D70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235048, XrefRangeEnd = 235054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x0020F540 File Offset: 0x0020D740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235062, RefRangeEnd = 235063, XrefRangeStart = 235054, XrefRangeEnd = 235062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x00039071 File Offset: 0x00037271
		public FloatSmoother(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x060078EF RID: 30959 RVA: 0x0020F57C File Offset: 0x0020D77C
		// (set) Token: 0x060078F0 RID: 30960 RVA: 0x0003907A File Offset: 0x0003727A
		public unsafe float _CurrentValue_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x060078F1 RID: 30961 RVA: 0x0020F5A4 File Offset: 0x0020D7A4
		// (set) Token: 0x060078F2 RID: 30962 RVA: 0x00039095 File Offset: 0x00037295
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x060078F3 RID: 30963 RVA: 0x0020F5CC File Offset: 0x0020D7CC
		// (set) Token: 0x060078F4 RID: 30964 RVA: 0x000390B0 File Offset: 0x000372B0
		public unsafe float DefaultValue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x060078F5 RID: 30965 RVA: 0x0020F5F4 File Offset: 0x0020D7F4
		// (set) Token: 0x060078F6 RID: 30966 RVA: 0x000390CB File Offset: 0x000372CB
		public unsafe float SmoothingSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x060078F7 RID: 30967 RVA: 0x0020F61C File Offset: 0x0020D81C
		// (set) Token: 0x060078F8 RID: 30968 RVA: 0x000390E6 File Offset: 0x000372E6
		public unsafe List<FloatSmoother.Override> overrides
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_overrides);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FloatSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400528A RID: 21130
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x0400528B RID: 21131
		private static readonly System.IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x0400528C RID: 21132
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x0400528D RID: 21133
		private static readonly System.IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x0400528E RID: 21134
		private static readonly System.IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x0400528F RID: 21135
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0;

		// Token: 0x04005290 RID: 21136
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0;

		// Token: 0x04005291 RID: 21137
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x04005292 RID: 21138
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x04005293 RID: 21139
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04005294 RID: 21140
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04005295 RID: 21141
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Single_0;

		// Token: 0x04005296 RID: 21142
		private static readonly System.IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x04005297 RID: 21143
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0;

		// Token: 0x04005298 RID: 21144
		private static readonly System.IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0;

		// Token: 0x04005299 RID: 21145
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x0400529A RID: 21146
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400529B RID: 21147
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEB RID: 2795
		public class Override : Il2CppSystem.Object
		{
			// Token: 0x0600D814 RID: 55316 RVA: 0x0033CA44 File Offset: 0x0033AC44
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr);
				FloatSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Value");
				FloatSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Priority");
				FloatSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Label");
				FloatSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, 100678624);
			}

			// Token: 0x0600D815 RID: 55317 RVA: 0x0033CAC0 File Offset: 0x0033ACC0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D816 RID: 55318 RVA: 0x00068DBA File Offset: 0x00066FBA
			public Override(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B7 RID: 17079
			// (get) Token: 0x0600D817 RID: 55319 RVA: 0x0033CAFC File Offset: 0x0033ACFC
			// (set) Token: 0x0600D818 RID: 55320 RVA: 0x00068DC3 File Offset: 0x00066FC3
			public unsafe float Value
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x170042B8 RID: 17080
			// (get) Token: 0x0600D819 RID: 55321 RVA: 0x0033CB24 File Offset: 0x0033AD24
			// (set) Token: 0x0600D81A RID: 55322 RVA: 0x00068DDE File Offset: 0x00066FDE
			public unsafe int Priority
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x170042B9 RID: 17081
			// (get) Token: 0x0600D81B RID: 55323 RVA: 0x0033CB4C File Offset: 0x0033AD4C
			// (set) Token: 0x0600D81C RID: 55324 RVA: 0x00068DF9 File Offset: 0x00066FF9
			public unsafe string Label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040091B3 RID: 37299
			private static readonly System.IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x040091B4 RID: 37300
			private static readonly System.IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x040091B5 RID: 37301
			private static readonly System.IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x040091B6 RID: 37302
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AEC RID: 2796
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D81D RID: 55325 RVA: 0x0033CB74 File Offset: 0x0033AD74
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr);
				FloatSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9");
				FloatSmoother.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9__17_1");
				FloatSmoother.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9__18_1");
				FloatSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678626);
				FloatSmoother.__c.NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678627);
				FloatSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678628);
			}

			// Token: 0x0600D81E RID: 55326 RVA: 0x0033CC18 File Offset: 0x0033AE18
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D81F RID: 55327 RVA: 0x0033CC54 File Offset: 0x0033AE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234838, XrefRangeEnd = 234840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__17_1(FloatSmoother.Override x, FloatSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D820 RID: 55328 RVA: 0x0033CCB4 File Offset: 0x0033AEB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__18_1(FloatSmoother.Override x, FloatSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D821 RID: 55329 RVA: 0x00068E18 File Offset: 0x00067018
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042BA RID: 17082
			// (get) Token: 0x0600D822 RID: 55330 RVA: 0x0033CD14 File Offset: 0x0033AF14
			// (set) Token: 0x0600D823 RID: 55331 RVA: 0x00068E21 File Offset: 0x00067021
			public unsafe static FloatSmoother.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BB RID: 17083
			// (get) Token: 0x0600D824 RID: 55332 RVA: 0x0033CD3C File Offset: 0x0033AF3C
			// (set) Token: 0x0600D825 RID: 55333 RVA: 0x00068E33 File Offset: 0x00067033
			public unsafe static Il2CppSystem.Comparison<FloatSmoother.Override> __9__17_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<FloatSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BC RID: 17084
			// (get) Token: 0x0600D826 RID: 55334 RVA: 0x0033CD64 File Offset: 0x0033AF64
			// (set) Token: 0x0600D827 RID: 55335 RVA: 0x00068E45 File Offset: 0x00067045
			public unsafe static Il2CppSystem.Comparison<FloatSmoother.Override> __9__18_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<FloatSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091B7 RID: 37303
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040091B8 RID: 37304
			private static readonly System.IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x040091B9 RID: 37305
			private static readonly System.IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x040091BA RID: 37306
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091BB RID: 37307
			private static readonly System.IntPtr NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0;

			// Token: 0x040091BC RID: 37308
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000AED RID: 2797
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D828 RID: 55336 RVA: 0x0033CD8C File Offset: 0x0033AF8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr);
				FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, "label");
				FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678629);
				FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678630);
			}

			// Token: 0x0600D829 RID: 55337 RVA: 0x0033CDF4 File Offset: 0x0033AFF4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D82A RID: 55338 RVA: 0x0033CE30 File Offset: 0x0033B030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234840, XrefRangeEnd = 234844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(FloatSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D82B RID: 55339 RVA: 0x00068E57 File Offset: 0x00067057
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042BD RID: 17085
			// (get) Token: 0x0600D82C RID: 55340 RVA: 0x0033CE80 File Offset: 0x0033B080
			// (set) Token: 0x0600D82D RID: 55341 RVA: 0x00068E60 File Offset: 0x00067060
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040091BD RID: 37309
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040091BE RID: 37310
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091BF RID: 37311
			private static readonly System.IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000AEE RID: 2798
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D82E RID: 55342 RVA: 0x0033CEA8 File Offset: 0x0033B0A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr);
				FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, "label");
				FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678631);
				FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678632);
			}

			// Token: 0x0600D82F RID: 55343 RVA: 0x0033CF10 File Offset: 0x0033B110
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D830 RID: 55344 RVA: 0x0033CF4C File Offset: 0x0033B14C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(FloatSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D831 RID: 55345 RVA: 0x00068E7F File Offset: 0x0006707F
			public __c__DisplayClass18_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042BE RID: 17086
			// (get) Token: 0x0600D832 RID: 55346 RVA: 0x0033CF9C File Offset: 0x0033B19C
			// (set) Token: 0x0600D833 RID: 55347 RVA: 0x00068E88 File Offset: 0x00067088
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040091C0 RID: 37312
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040091C1 RID: 37313
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091C2 RID: 37314
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
