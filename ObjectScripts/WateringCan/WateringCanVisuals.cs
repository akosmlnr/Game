using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200078A RID: 1930
	public class WateringCanVisuals : MonoBehaviour
	{
		// Token: 0x0600B755 RID: 46933 RVA: 0x002DE2CC File Offset: 0x002DC4CC
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanVisuals()
		{
			Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr);
			WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "OverflowParticles");
			WateringCanVisuals.NativeFieldInfoPtr_WaterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterTransform");
			WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterMaxY");
			WateringCanVisuals.NativeFieldInfoPtr_WaterMinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterMinY");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterTransform");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterMinScale");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterMaxScale");
			WateringCanVisuals.NativeFieldInfoPtr_FillSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "FillSound");
			WateringCanVisuals.NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100686060);
			WateringCanVisuals.NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100686061);
			WateringCanVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100686062);
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x002DE3D8 File Offset: 0x002DC5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314821, XrefRangeEnd = 314834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFillLevel(float normalizedFillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedFillLevel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanVisuals.NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x002DE424 File Offset: 0x002DC624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314836, RefRangeEnd = 314837, XrefRangeStart = 314834, XrefRangeEnd = 314836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverflowParticles(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanVisuals.NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x002DE464 File Offset: 0x002DC664
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x00059732 File Offset: 0x00057932
		public WateringCanVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600B75A RID: 46938 RVA: 0x002DE4A0 File Offset: 0x002DC6A0
		// (set) Token: 0x0600B75B RID: 46939 RVA: 0x0005973B File Offset: 0x0005793B
		public unsafe ParticleSystem OverflowParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600B75C RID: 46940 RVA: 0x002DE4D0 File Offset: 0x002DC6D0
		// (set) Token: 0x0600B75D RID: 46941 RVA: 0x0005975A File Offset: 0x0005795A
		public unsafe Transform WaterTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600B75E RID: 46942 RVA: 0x002DE500 File Offset: 0x002DC700
		// (set) Token: 0x0600B75F RID: 46943 RVA: 0x00059779 File Offset: 0x00057979
		public unsafe float WaterMaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY)) = value;
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600B760 RID: 46944 RVA: 0x002DE528 File Offset: 0x002DC728
		// (set) Token: 0x0600B761 RID: 46945 RVA: 0x00059794 File Offset: 0x00057994
		public unsafe float WaterMinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMinY)) = value;
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600B762 RID: 46946 RVA: 0x002DE550 File Offset: 0x002DC750
		// (set) Token: 0x0600B763 RID: 46947 RVA: 0x000597AF File Offset: 0x000579AF
		public unsafe Transform SideWaterTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600B764 RID: 46948 RVA: 0x002DE580 File Offset: 0x002DC780
		// (set) Token: 0x0600B765 RID: 46949 RVA: 0x000597CE File Offset: 0x000579CE
		public unsafe float SideWaterMinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale)) = value;
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600B766 RID: 46950 RVA: 0x002DE5A8 File Offset: 0x002DC7A8
		// (set) Token: 0x0600B767 RID: 46951 RVA: 0x000597E9 File Offset: 0x000579E9
		public unsafe float SideWaterMaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale)) = value;
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600B768 RID: 46952 RVA: 0x002DE5D0 File Offset: 0x002DC7D0
		// (set) Token: 0x0600B769 RID: 46953 RVA: 0x00059804 File Offset: 0x00057A04
		public unsafe AudioSourceController FillSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_FillSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_FillSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BD2 RID: 31698
		private static readonly IntPtr NativeFieldInfoPtr_OverflowParticles;

		// Token: 0x04007BD3 RID: 31699
		private static readonly IntPtr NativeFieldInfoPtr_WaterTransform;

		// Token: 0x04007BD4 RID: 31700
		private static readonly IntPtr NativeFieldInfoPtr_WaterMaxY;

		// Token: 0x04007BD5 RID: 31701
		private static readonly IntPtr NativeFieldInfoPtr_WaterMinY;

		// Token: 0x04007BD6 RID: 31702
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterTransform;

		// Token: 0x04007BD7 RID: 31703
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterMinScale;

		// Token: 0x04007BD8 RID: 31704
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterMaxScale;

		// Token: 0x04007BD9 RID: 31705
		private static readonly IntPtr NativeFieldInfoPtr_FillSound;

		// Token: 0x04007BDA RID: 31706
		private static readonly IntPtr NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x04007BDB RID: 31707
		private static readonly IntPtr NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0;

		// Token: 0x04007BDC RID: 31708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
