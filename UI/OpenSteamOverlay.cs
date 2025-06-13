using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000646 RID: 1606
	public class OpenSteamOverlay : MonoBehaviour
	{
		// Token: 0x06008CB4 RID: 36020 RVA: 0x0025037C File Offset: 0x0024E57C
		// Note: this type is marked as 'beforefieldinit'.
		static OpenSteamOverlay()
		{
			Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "OpenSteamOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr);
			OpenSteamOverlay.NativeFieldInfoPtr_APP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "APP_ID");
			OpenSteamOverlay.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "Type");
			OpenSteamOverlay.NativeFieldInfoPtr_CustomLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "CustomLink");
			OpenSteamOverlay.NativeMethodInfoPtr_OpenOverlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, 100680878);
			OpenSteamOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, 100680879);
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00250410 File Offset: 0x0024E610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258196, XrefRangeEnd = 258199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenOverlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenSteamOverlay.NativeMethodInfoPtr_OpenOverlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x00250444 File Offset: 0x0024E644
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpenSteamOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenSteamOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x000430B5 File Offset: 0x000412B5
		public OpenSteamOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x06008CB8 RID: 36024 RVA: 0x00250480 File Offset: 0x0024E680
		// (set) Token: 0x06008CB9 RID: 36025 RVA: 0x000430BE File Offset: 0x000412BE
		public unsafe static uint APP_ID
		{
			get
			{
				uint result;
				IL2CPP.il2cpp_field_static_get_value(OpenSteamOverlay.NativeFieldInfoPtr_APP_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OpenSteamOverlay.NativeFieldInfoPtr_APP_ID, (void*)(&value));
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x06008CBA RID: 36026 RVA: 0x0025049C File Offset: 0x0024E69C
		// (set) Token: 0x06008CBB RID: 36027 RVA: 0x000430CC File Offset: 0x000412CC
		public unsafe OpenSteamOverlay.EType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x06008CBC RID: 36028 RVA: 0x002504C4 File Offset: 0x0024E6C4
		// (set) Token: 0x06008CBD RID: 36029 RVA: 0x000430E7 File Offset: 0x000412E7
		public unsafe string CustomLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_CustomLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_CustomLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005F7D RID: 24445
		private static readonly IntPtr NativeFieldInfoPtr_APP_ID;

		// Token: 0x04005F7E RID: 24446
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04005F7F RID: 24447
		private static readonly IntPtr NativeFieldInfoPtr_CustomLink;

		// Token: 0x04005F80 RID: 24448
		private static readonly IntPtr NativeMethodInfoPtr_OpenOverlay_Public_Void_0;

		// Token: 0x04005F81 RID: 24449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5F RID: 2911
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x040093E2 RID: 37858
			Store,
			// Token: 0x040093E3 RID: 37859
			CustomLink
		}
	}
}
