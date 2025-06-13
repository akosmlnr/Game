using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000487 RID: 1159
	public class PlaceholderBuilding : MonoBehaviour
	{
		// Token: 0x0600638A RID: 25482 RVA: 0x001C77A8 File Offset: 0x001C59A8
		// Note: this type is marked as 'beforefieldinit'.
		static PlaceholderBuilding()
		{
			Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlaceholderBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr);
			PlaceholderBuilding.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Name");
			PlaceholderBuilding.NativeFieldInfoPtr_Dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Dimensions");
			PlaceholderBuilding.NativeFieldInfoPtr_AutoGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "AutoGround");
			PlaceholderBuilding.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Model");
			PlaceholderBuilding.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Label");
			PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "lastFramePosition");
			PlaceholderBuilding.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100676039);
			PlaceholderBuilding.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100676040);
			PlaceholderBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100676041);
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x001C788C File Offset: 0x001C5A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205583, XrefRangeEnd = 205591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceholderBuilding.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x001C78C0 File Offset: 0x001C5AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205591, XrefRangeEnd = 205635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceholderBuilding.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x001C78FC File Offset: 0x001C5AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205635, XrefRangeEnd = 205638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaceholderBuilding() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceholderBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x0002ED12 File Offset: 0x0002CF12
		public PlaceholderBuilding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x0600638F RID: 25487 RVA: 0x001C7938 File Offset: 0x001C5B38
		// (set) Token: 0x06006390 RID: 25488 RVA: 0x0002ED1B File Offset: 0x0002CF1B
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06006391 RID: 25489 RVA: 0x001C7960 File Offset: 0x001C5B60
		// (set) Token: 0x06006392 RID: 25490 RVA: 0x0002ED3A File Offset: 0x0002CF3A
		public unsafe Vector3 Dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Dimensions)) = value;
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06006393 RID: 25491 RVA: 0x001C7988 File Offset: 0x001C5B88
		// (set) Token: 0x06006394 RID: 25492 RVA: 0x0002ED55 File Offset: 0x0002CF55
		public unsafe bool AutoGround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_AutoGround);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_AutoGround)) = value;
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06006395 RID: 25493 RVA: 0x001C79B0 File Offset: 0x001C5BB0
		// (set) Token: 0x06006396 RID: 25494 RVA: 0x0002ED70 File Offset: 0x0002CF70
		public unsafe Transform Model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06006397 RID: 25495 RVA: 0x001C79E0 File Offset: 0x001C5BE0
		// (set) Token: 0x06006398 RID: 25496 RVA: 0x0002ED8F File Offset: 0x0002CF8F
		public unsafe TextMeshPro Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06006399 RID: 25497 RVA: 0x001C7A10 File Offset: 0x001C5C10
		// (set) Token: 0x0600639A RID: 25498 RVA: 0x0002EDAE File Offset: 0x0002CFAE
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x040043EA RID: 17386
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040043EB RID: 17387
		private static readonly IntPtr NativeFieldInfoPtr_Dimensions;

		// Token: 0x040043EC RID: 17388
		private static readonly IntPtr NativeFieldInfoPtr_AutoGround;

		// Token: 0x040043ED RID: 17389
		private static readonly IntPtr NativeFieldInfoPtr_Model;

		// Token: 0x040043EE RID: 17390
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x040043EF RID: 17391
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x040043F0 RID: 17392
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040043F1 RID: 17393
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040043F2 RID: 17394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
