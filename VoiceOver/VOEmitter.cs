using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x0200017C RID: 380
	public class VOEmitter : MonoBehaviour
	{
		// Token: 0x06001E18 RID: 7704 RVA: 0x000D0FE8 File Offset: 0x000CF1E8
		// Note: this type is marked as 'beforefieldinit'.
		static VOEmitter()
		{
			Il2CppClassPointerStore<VOEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VOEmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr);
			VOEmitter.NativeFieldInfoPtr_PitchVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "PitchVariation");
			VOEmitter.NativeFieldInfoPtr_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "Database");
			VOEmitter.NativeFieldInfoPtr_PitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "PitchMultiplier");
			VOEmitter.NativeFieldInfoPtr_runtimePitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "runtimePitchMultiplier");
			VOEmitter.NativeFieldInfoPtr_audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "audioSourceController");
			VOEmitter.NativeFieldInfoPtr_defaultVODatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "defaultVODatabase");
			VOEmitter.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666756);
			VOEmitter.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666757);
			VOEmitter.NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666758);
			VOEmitter.NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666759);
			VOEmitter.NativeMethodInfoPtr_ResetDatabase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666760);
			VOEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666761);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000D1108 File Offset: 0x000CF308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109784, XrefRangeEnd = 109788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VOEmitter.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000D1144 File Offset: 0x000CF344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109815, RefRangeEnd = 109817, XrefRangeStart = 109788, XrefRangeEnd = 109815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VOEmitter.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x000D1190 File Offset: 0x000CF390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109817, RefRangeEnd = 109819, XrefRangeStart = 109817, XrefRangeEnd = 109817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRuntimePitchMultiplier(float pitchMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pitchMultiplier;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000D11D0 File Offset: 0x000CF3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109821, RefRangeEnd = 109823, XrefRangeStart = 109819, XrefRangeEnd = 109821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDatabase(VODatabase database, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000D1220 File Offset: 0x000CF420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109824, RefRangeEnd = 109825, XrefRangeStart = 109823, XrefRangeEnd = 109824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetDatabase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_ResetDatabase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000D1254 File Offset: 0x000CF454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VOEmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00010E36 File Offset: 0x0000F036
		public VOEmitter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000D1290 File Offset: 0x000CF490
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00010E3F File Offset: 0x0000F03F
		public unsafe static float PitchVariation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VOEmitter.NativeFieldInfoPtr_PitchVariation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VOEmitter.NativeFieldInfoPtr_PitchVariation, (void*)(&value));
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x000D12AC File Offset: 0x000CF4AC
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00010E4D File Offset: 0x0000F04D
		public unsafe VODatabase Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x000D12DC File Offset: 0x000CF4DC
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00010E6C File Offset: 0x0000F06C
		public unsafe float PitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_PitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_PitchMultiplier)) = value;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x000D1304 File Offset: 0x000CF504
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00010E87 File Offset: 0x0000F087
		public unsafe float runtimePitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_runtimePitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_runtimePitchMultiplier)) = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000D132C File Offset: 0x000CF52C
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00010EA2 File Offset: 0x0000F0A2
		public unsafe AudioSourceController audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000D135C File Offset: 0x000CF55C
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00010EC1 File Offset: 0x0000F0C1
		public unsafe VODatabase defaultVODatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_defaultVODatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_defaultVODatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeFieldInfoPtr_PitchVariation;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeFieldInfoPtr_Database;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeFieldInfoPtr_PitchMultiplier;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeFieldInfoPtr_runtimePitchMultiplier;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceController;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeFieldInfoPtr_defaultVODatabase;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_ResetDatabase_Public_Void_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
