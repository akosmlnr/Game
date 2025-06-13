using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.TV;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000648 RID: 1608
	public class TVPauseScreen : MonoBehaviour
	{
		// Token: 0x06008CC4 RID: 36036 RVA: 0x0025065C File Offset: 0x0024E85C
		// Note: this type is marked as 'beforefieldinit'.
		static TVPauseScreen()
		{
			Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TVPauseScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr);
			TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, "<IsPaused>k__BackingField");
			TVPauseScreen.NativeFieldInfoPtr_App = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, "App");
			TVPauseScreen.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680884);
			TVPauseScreen.NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680885);
			TVPauseScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680886);
			TVPauseScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680887);
			TVPauseScreen.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680888);
			TVPauseScreen.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680889);
			TVPauseScreen.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680890);
			TVPauseScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680891);
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x06008CC5 RID: 36037 RVA: 0x00250754 File Offset: 0x0024E954
		// (set) Token: 0x06008CC6 RID: 36038 RVA: 0x00250790 File Offset: 0x0024E990
		public unsafe bool IsPaused
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x002507D0 File Offset: 0x0024E9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258230, XrefRangeEnd = 258240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x00250804 File Offset: 0x0024EA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258240, XrefRangeEnd = 258241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x00250848 File Offset: 0x0024EA48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 258244, RefRangeEnd = 258248, XrefRangeStart = 258241, XrefRangeEnd = 258244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x0025087C File Offset: 0x0024EA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258248, XrefRangeEnd = 258251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CCB RID: 36043 RVA: 0x002508B0 File Offset: 0x0024EAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258251, XrefRangeEnd = 258252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x002508E4 File Offset: 0x0024EAE4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVPauseScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x0004310F File Offset: 0x0004130F
		public TVPauseScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x06008CCE RID: 36046 RVA: 0x00250920 File Offset: 0x0024EB20
		// (set) Token: 0x06008CCF RID: 36047 RVA: 0x00043118 File Offset: 0x00041318
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x06008CD0 RID: 36048 RVA: 0x00250948 File Offset: 0x0024EB48
		// (set) Token: 0x06008CD1 RID: 36049 RVA: 0x00043133 File Offset: 0x00041333
		public unsafe TVApp App
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr_App);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr_App), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F86 RID: 24454
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x04005F87 RID: 24455
		private static readonly IntPtr NativeFieldInfoPtr_App;

		// Token: 0x04005F88 RID: 24456
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x04005F89 RID: 24457
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0;

		// Token: 0x04005F8A RID: 24458
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005F8B RID: 24459
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005F8C RID: 24460
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04005F8D RID: 24461
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

		// Token: 0x04005F8E RID: 24462
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04005F8F RID: 24463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
