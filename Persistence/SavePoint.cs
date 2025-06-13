using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000230 RID: 560
	public class SavePoint : MonoBehaviour
	{
		// Token: 0x06002E5F RID: 11871 RVA: 0x00106BE4 File Offset: 0x00104DE4
		// Note: this type is marked as 'beforefieldinit'.
		static SavePoint()
		{
			Il2CppClassPointerStore<SavePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SavePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavePoint>.NativeClassPtr);
			SavePoint.NativeFieldInfoPtr_SAVE_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, "SAVE_COOLDOWN");
			SavePoint.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, "IntObj");
			SavePoint.NativeFieldInfoPtr_onSaveStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, "onSaveStart");
			SavePoint.NativeFieldInfoPtr_onSaveComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, "onSaveComplete");
			SavePoint.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668650);
			SavePoint.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668651);
			SavePoint.NativeMethodInfoPtr_CanSave_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668652);
			SavePoint.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668653);
			SavePoint.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668654);
			SavePoint.NativeMethodInfoPtr_OnSaveStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668655);
			SavePoint.NativeMethodInfoPtr_OnSaveComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668656);
			SavePoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePoint>.NativeClassPtr, 100668657);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00106D04 File Offset: 0x00104F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130807, XrefRangeEnd = 130856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00106D38 File Offset: 0x00104F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130856, XrefRangeEnd = 130868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00106D6C File Offset: 0x00104F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130880, RefRangeEnd = 130882, XrefRangeStart = 130868, XrefRangeEnd = 130880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSave(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_CanSave_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00106DC4 File Offset: 0x00104FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130882, XrefRangeEnd = 130888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00106DF8 File Offset: 0x00104FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130888, XrefRangeEnd = 130894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00106E2C File Offset: 0x0010502C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130895, RefRangeEnd = 130899, XrefRangeStart = 130894, XrefRangeEnd = 130895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSaveStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_OnSaveStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00106E60 File Offset: 0x00105060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130899, XrefRangeEnd = 130900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSaveComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr_OnSaveComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00106E94 File Offset: 0x00105094
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SavePoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavePoint>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00018C7F File Offset: 0x00016E7F
		public SavePoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x00106ED0 File Offset: 0x001050D0
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x00018C88 File Offset: 0x00016E88
		public unsafe static float SAVE_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SavePoint.NativeFieldInfoPtr_SAVE_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SavePoint.NativeFieldInfoPtr_SAVE_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x00106EEC File Offset: 0x001050EC
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x00018C96 File Offset: 0x00016E96
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x00106F1C File Offset: 0x0010511C
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x00018CB5 File Offset: 0x00016EB5
		public unsafe UnityEvent onSaveStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_onSaveStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_onSaveStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x00106F4C File Offset: 0x0010514C
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x00018CD4 File Offset: 0x00016ED4
		public unsafe UnityEvent onSaveComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_onSaveComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavePoint.NativeFieldInfoPtr_onSaveComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_COOLDOWN;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeFieldInfoPtr_onSaveStart;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeFieldInfoPtr_onSaveComplete;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_CanSave_Private_Boolean_byref_String_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_Save_Private_Void_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_OnSaveStart_Public_Void_0;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr_OnSaveComplete_Public_Void_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
