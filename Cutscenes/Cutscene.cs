using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x020004A0 RID: 1184
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x060065A2 RID: 26018 RVA: 0x001CE6B0 File Offset: 0x001CC8B0
		// Note: this type is marked as 'beforefieldinit'.
		static Cutscene()
		{
			Il2CppClassPointerStore<Cutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "Cutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cutscene>.NativeClassPtr);
			Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "<IsPlaying>k__BackingField");
			Cutscene.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "Name");
			Cutscene.NativeFieldInfoPtr_DisablePlayerControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "DisablePlayerControl");
			Cutscene.NativeFieldInfoPtr_OverrideFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "OverrideFOV");
			Cutscene.NativeFieldInfoPtr_CameraFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "CameraFOV");
			Cutscene.NativeFieldInfoPtr_CameraControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "CameraControl");
			Cutscene.NativeFieldInfoPtr_onPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "onPlay");
			Cutscene.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "onEnd");
			Cutscene.NativeFieldInfoPtr_animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "animation");
			Cutscene.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100676277);
			Cutscene.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100676278);
			Cutscene.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100676279);
			Cutscene.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100676280);
			Cutscene.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100676281);
			Cutscene.NativeMethodInfoPtr_InvokeEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100676282);
			Cutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100676283);
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x001CE820 File Offset: 0x001CCA20
		// (set) Token: 0x060065A4 RID: 26020 RVA: 0x001CE85C File Offset: 0x001CCA5C
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x001CE89C File Offset: 0x001CCA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208192, XrefRangeEnd = 208196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cutscene.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x001CE8D8 File Offset: 0x001CCAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208196, XrefRangeEnd = 208209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x001CE90C File Offset: 0x001CCB0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208252, RefRangeEnd = 208253, XrefRangeStart = 208209, XrefRangeEnd = 208252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cutscene.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x001CE948 File Offset: 0x001CCB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208253, XrefRangeEnd = 208299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_InvokeEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x001CE97C File Offset: 0x001CCB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208299, XrefRangeEnd = 208304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cutscene>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x0002FCED File Offset: 0x0002DEED
		public Cutscene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x060065AB RID: 26027 RVA: 0x001CE9B8 File Offset: 0x001CCBB8
		// (set) Token: 0x060065AC RID: 26028 RVA: 0x0002FCF6 File Offset: 0x0002DEF6
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x001CE9E0 File Offset: 0x001CCBE0
		// (set) Token: 0x060065AE RID: 26030 RVA: 0x0002FD11 File Offset: 0x0002DF11
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x060065AF RID: 26031 RVA: 0x001CEA08 File Offset: 0x001CCC08
		// (set) Token: 0x060065B0 RID: 26032 RVA: 0x0002FD30 File Offset: 0x0002DF30
		public unsafe bool DisablePlayerControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_DisablePlayerControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_DisablePlayerControl)) = value;
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x060065B1 RID: 26033 RVA: 0x001CEA30 File Offset: 0x001CCC30
		// (set) Token: 0x060065B2 RID: 26034 RVA: 0x0002FD4B File Offset: 0x0002DF4B
		public unsafe bool OverrideFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_OverrideFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_OverrideFOV)) = value;
			}
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x060065B3 RID: 26035 RVA: 0x001CEA58 File Offset: 0x001CCC58
		// (set) Token: 0x060065B4 RID: 26036 RVA: 0x0002FD66 File Offset: 0x0002DF66
		public unsafe float CameraFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraFOV)) = value;
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x060065B5 RID: 26037 RVA: 0x001CEA80 File Offset: 0x001CCC80
		// (set) Token: 0x060065B6 RID: 26038 RVA: 0x0002FD81 File Offset: 0x0002DF81
		public unsafe Transform CameraControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x060065B7 RID: 26039 RVA: 0x001CEAB0 File Offset: 0x001CCCB0
		// (set) Token: 0x060065B8 RID: 26040 RVA: 0x0002FDA0 File Offset: 0x0002DFA0
		public unsafe UnityEvent onPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x060065B9 RID: 26041 RVA: 0x001CEAE0 File Offset: 0x001CCCE0
		// (set) Token: 0x060065BA RID: 26042 RVA: 0x0002FDBF File Offset: 0x0002DFBF
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x060065BB RID: 26043 RVA: 0x001CEB10 File Offset: 0x001CCD10
		// (set) Token: 0x060065BC RID: 26044 RVA: 0x0002FDDE File Offset: 0x0002DFDE
		public unsafe Animation animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004561 RID: 17761
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04004562 RID: 17762
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04004563 RID: 17763
		private static readonly IntPtr NativeFieldInfoPtr_DisablePlayerControl;

		// Token: 0x04004564 RID: 17764
		private static readonly IntPtr NativeFieldInfoPtr_OverrideFOV;

		// Token: 0x04004565 RID: 17765
		private static readonly IntPtr NativeFieldInfoPtr_CameraFOV;

		// Token: 0x04004566 RID: 17766
		private static readonly IntPtr NativeFieldInfoPtr_CameraControl;

		// Token: 0x04004567 RID: 17767
		private static readonly IntPtr NativeFieldInfoPtr_onPlay;

		// Token: 0x04004568 RID: 17768
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x04004569 RID: 17769
		private static readonly IntPtr NativeFieldInfoPtr_animation;

		// Token: 0x0400456A RID: 17770
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x0400456B RID: 17771
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x0400456C RID: 17772
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400456D RID: 17773
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400456E RID: 17774
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x0400456F RID: 17775
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEnd_Public_Void_0;

		// Token: 0x04004570 RID: 17776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
