using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005C0 RID: 1472
	[System.Serializable]
	public class PropertyContainer : Il2CppSystem.Object
	{
		// Token: 0x06008009 RID: 32777 RVA: 0x00226754 File Offset: 0x00224954
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyContainer()
		{
			Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr);
			PropertyContainer.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr, "Property");
			PropertyContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr, 100679406);
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x002267AC File Offset: 0x002249AC
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x0003C976 File Offset: 0x0003AB76
		public PropertyContainer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600800C RID: 32780 RVA: 0x002267E8 File Offset: 0x002249E8
		// (set) Token: 0x0600800D RID: 32781 RVA: 0x0003C97F File Offset: 0x0003AB7F
		public unsafe EProperty Property
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContainer.NativeFieldInfoPtr_Property);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContainer.NativeFieldInfoPtr_Property)) = value;
			}
		}

		// Token: 0x0400572F RID: 22319
		private static readonly System.IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04005730 RID: 22320
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
