using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x020005A3 RID: 1443
	public class StoredItem_GenericBox : StoredItem
	{
		// Token: 0x06007E12 RID: 32274 RVA: 0x00220748 File Offset: 0x0021E948
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_GenericBox()
		{
			Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItem_GenericBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr);
			StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "ReferenceIconWidth");
			StoredItem_GenericBox.NativeFieldInfoPtr_icon1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "icon1");
			StoredItem_GenericBox.NativeFieldInfoPtr_icon2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "icon2");
			StoredItem_GenericBox.NativeFieldInfoPtr_IconScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "IconScale");
			StoredItem_GenericBox.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, 100679203);
			StoredItem_GenericBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, 100679204);
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x002207F0 File Offset: 0x0021E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240914, XrefRangeEnd = 240922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem_GenericBox.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x0022086C File Offset: 0x0021EA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240922, XrefRangeEnd = 240923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_GenericBox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_GenericBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x0003B903 File Offset: 0x00039B03
		public StoredItem_GenericBox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x06007E16 RID: 32278 RVA: 0x002208A8 File Offset: 0x0021EAA8
		// (set) Token: 0x06007E17 RID: 32279 RVA: 0x0003B90C File Offset: 0x00039B0C
		public unsafe static float ReferenceIconWidth
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth, (void*)(&value));
			}
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x06007E18 RID: 32280 RVA: 0x002208C4 File Offset: 0x0021EAC4
		// (set) Token: 0x06007E19 RID: 32281 RVA: 0x0003B91A File Offset: 0x00039B1A
		public unsafe SpriteRenderer icon1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x002208F4 File Offset: 0x0021EAF4
		// (set) Token: 0x06007E1B RID: 32283 RVA: 0x0003B939 File Offset: 0x00039B39
		public unsafe SpriteRenderer icon2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x06007E1C RID: 32284 RVA: 0x00220924 File Offset: 0x0021EB24
		// (set) Token: 0x06007E1D RID: 32285 RVA: 0x0003B958 File Offset: 0x00039B58
		public unsafe float IconScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_IconScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_IconScale)) = value;
			}
		}

		// Token: 0x040055E0 RID: 21984
		private static readonly IntPtr NativeFieldInfoPtr_ReferenceIconWidth;

		// Token: 0x040055E1 RID: 21985
		private static readonly IntPtr NativeFieldInfoPtr_icon1;

		// Token: 0x040055E2 RID: 21986
		private static readonly IntPtr NativeFieldInfoPtr_icon2;

		// Token: 0x040055E3 RID: 21987
		private static readonly IntPtr NativeFieldInfoPtr_IconScale;

		// Token: 0x040055E4 RID: 21988
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x040055E5 RID: 21989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
