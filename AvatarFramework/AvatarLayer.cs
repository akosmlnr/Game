using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000617 RID: 1559
	[Serializable]
	public class AvatarLayer : ScriptableObject
	{
		// Token: 0x06008800 RID: 34816 RVA: 0x002428A4 File Offset: 0x00240AA4
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLayer()
		{
			Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr);
			AvatarLayer.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Name");
			AvatarLayer.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "AssetPath");
			AvatarLayer.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Texture");
			AvatarLayer.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Normal");
			AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Normal_DefaultFormat");
			AvatarLayer.NativeFieldInfoPtr_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Order");
			AvatarLayer.NativeFieldInfoPtr_CombinedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "CombinedMaterial");
			AvatarLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, 100680386);
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x00242974 File Offset: 0x00240B74
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 92196, RefRangeEnd = 92208, XrefRangeStart = 92196, XrefRangeEnd = 92208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x00040592 File Offset: 0x0003E792
		public AvatarLayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x06008803 RID: 34819 RVA: 0x002429B0 File Offset: 0x00240BB0
		// (set) Token: 0x06008804 RID: 34820 RVA: 0x0004059B File Offset: 0x0003E79B
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x06008805 RID: 34821 RVA: 0x002429D8 File Offset: 0x00240BD8
		// (set) Token: 0x06008806 RID: 34822 RVA: 0x000405BA File Offset: 0x0003E7BA
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x06008807 RID: 34823 RVA: 0x00242A00 File Offset: 0x00240C00
		// (set) Token: 0x06008808 RID: 34824 RVA: 0x000405D9 File Offset: 0x0003E7D9
		public unsafe Texture2D Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x06008809 RID: 34825 RVA: 0x00242A30 File Offset: 0x00240C30
		// (set) Token: 0x0600880A RID: 34826 RVA: 0x000405F8 File Offset: 0x0003E7F8
		public unsafe Texture2D Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0600880B RID: 34827 RVA: 0x00242A60 File Offset: 0x00240C60
		// (set) Token: 0x0600880C RID: 34828 RVA: 0x00040617 File Offset: 0x0003E817
		public unsafe Texture2D Normal_DefaultFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x00242A90 File Offset: 0x00240C90
		// (set) Token: 0x0600880E RID: 34830 RVA: 0x00040636 File Offset: 0x0003E836
		public unsafe int Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Order)) = value;
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x0600880F RID: 34831 RVA: 0x00242AB8 File Offset: 0x00240CB8
		// (set) Token: 0x06008810 RID: 34832 RVA: 0x00040651 File Offset: 0x0003E851
		public unsafe Material CombinedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_CombinedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_CombinedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C9D RID: 23709
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005C9E RID: 23710
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005C9F RID: 23711
		private static readonly IntPtr NativeFieldInfoPtr_Texture;

		// Token: 0x04005CA0 RID: 23712
		private static readonly IntPtr NativeFieldInfoPtr_Normal;

		// Token: 0x04005CA1 RID: 23713
		private static readonly IntPtr NativeFieldInfoPtr_Normal_DefaultFormat;

		// Token: 0x04005CA2 RID: 23714
		private static readonly IntPtr NativeFieldInfoPtr_Order;

		// Token: 0x04005CA3 RID: 23715
		private static readonly IntPtr NativeFieldInfoPtr_CombinedMaterial;

		// Token: 0x04005CA4 RID: 23716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
