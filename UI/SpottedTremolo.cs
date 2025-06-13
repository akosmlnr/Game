using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Stealth;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000645 RID: 1605
	public class SpottedTremolo : MonoBehaviour
	{
		// Token: 0x06008C9E RID: 35998 RVA: 0x00250088 File Offset: 0x0024E288
		// Note: this type is marked as 'beforefieldinit'.
		static SpottedTremolo()
		{
			Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SpottedTremolo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr);
			SpottedTremolo.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "Intensity");
			SpottedTremolo.NativeFieldInfoPtr_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "Loop");
			SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "PlayerVisibility");
			SpottedTremolo.NativeFieldInfoPtr_MinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MinVolume");
			SpottedTremolo.NativeFieldInfoPtr_MaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MaxVolume");
			SpottedTremolo.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MinPitch");
			SpottedTremolo.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MaxPitch");
			SpottedTremolo.NativeFieldInfoPtr_SmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "SmoothTime");
			SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "smoothedIntensity");
			SpottedTremolo.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100680876);
			SpottedTremolo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100680877);
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x00250194 File Offset: 0x0024E394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258185, XrefRangeEnd = 258195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CA0 RID: 36000 RVA: 0x002501C8 File Offset: 0x0024E3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258195, XrefRangeEnd = 258196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpottedTremolo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CA1 RID: 36001 RVA: 0x00042FB1 File Offset: 0x000411B1
		public SpottedTremolo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x06008CA2 RID: 36002 RVA: 0x00250204 File Offset: 0x0024E404
		// (set) Token: 0x06008CA3 RID: 36003 RVA: 0x00042FBA File Offset: 0x000411BA
		public unsafe float Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Intensity)) = value;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x06008CA4 RID: 36004 RVA: 0x0025022C File Offset: 0x0024E42C
		// (set) Token: 0x06008CA5 RID: 36005 RVA: 0x00042FD5 File Offset: 0x000411D5
		public unsafe AudioSourceController Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Loop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Loop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x06008CA6 RID: 36006 RVA: 0x0025025C File Offset: 0x0024E45C
		// (set) Token: 0x06008CA7 RID: 36007 RVA: 0x00042FF4 File Offset: 0x000411F4
		public unsafe PlayerVisibility PlayerVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x06008CA8 RID: 36008 RVA: 0x0025028C File Offset: 0x0024E48C
		// (set) Token: 0x06008CA9 RID: 36009 RVA: 0x00043013 File Offset: 0x00041213
		public unsafe float MinVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinVolume)) = value;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x06008CAA RID: 36010 RVA: 0x002502B4 File Offset: 0x0024E4B4
		// (set) Token: 0x06008CAB RID: 36011 RVA: 0x0004302E File Offset: 0x0004122E
		public unsafe float MaxVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxVolume)) = value;
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x06008CAC RID: 36012 RVA: 0x002502DC File Offset: 0x0024E4DC
		// (set) Token: 0x06008CAD RID: 36013 RVA: 0x00043049 File Offset: 0x00041249
		public unsafe float MinPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinPitch)) = value;
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x06008CAE RID: 36014 RVA: 0x00250304 File Offset: 0x0024E504
		// (set) Token: 0x06008CAF RID: 36015 RVA: 0x00043064 File Offset: 0x00041264
		public unsafe float MaxPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxPitch)) = value;
			}
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x06008CB0 RID: 36016 RVA: 0x0025032C File Offset: 0x0024E52C
		// (set) Token: 0x06008CB1 RID: 36017 RVA: 0x0004307F File Offset: 0x0004127F
		public unsafe float SmoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_SmoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_SmoothTime)) = value;
			}
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x06008CB2 RID: 36018 RVA: 0x00250354 File Offset: 0x0024E554
		// (set) Token: 0x06008CB3 RID: 36019 RVA: 0x0004309A File Offset: 0x0004129A
		public unsafe float smoothedIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity)) = value;
			}
		}

		// Token: 0x04005F72 RID: 24434
		private static readonly IntPtr NativeFieldInfoPtr_Intensity;

		// Token: 0x04005F73 RID: 24435
		private static readonly IntPtr NativeFieldInfoPtr_Loop;

		// Token: 0x04005F74 RID: 24436
		private static readonly IntPtr NativeFieldInfoPtr_PlayerVisibility;

		// Token: 0x04005F75 RID: 24437
		private static readonly IntPtr NativeFieldInfoPtr_MinVolume;

		// Token: 0x04005F76 RID: 24438
		private static readonly IntPtr NativeFieldInfoPtr_MaxVolume;

		// Token: 0x04005F77 RID: 24439
		private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

		// Token: 0x04005F78 RID: 24440
		private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

		// Token: 0x04005F79 RID: 24441
		private static readonly IntPtr NativeFieldInfoPtr_SmoothTime;

		// Token: 0x04005F7A RID: 24442
		private static readonly IntPtr NativeFieldInfoPtr_smoothedIntensity;

		// Token: 0x04005F7B RID: 24443
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005F7C RID: 24444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
